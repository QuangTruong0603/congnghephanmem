using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using AForge.Video.DirectShow;
using System.Threading;
using AForge.Video;
using System.Media;
using ZXing;
using iTextSharp.text.pdf;

namespace GUI
{
    public partial class ThemSanPhamOrder : Form
    {

        private int idOrder;

        private BLL_Order bLL_Order = new BLL_Order();
        private BLL_Product bLL_Product = new BLL_Product();
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;


        public ThemSanPhamOrder(int idOrder)
        {
            InitializeComponent();
            this.idOrder = idOrder;

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cboCamera.Items.Add(Device.Name);
            if (cboCamera.Items.Count > 0)
            {
                cboCamera.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
            }

        }

        private void ThemSanPhamOrder_Load(object sender, EventArgs e)
        {

        }

        private void tb_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void tb_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string barcode = tb_barcode.Text.ToString();
            string txtSoluong = tb_soluong.Text.ToString();
            string size = tb_size.Text.ToString();

            if (barcode == "" || txtSoluong == "" || size == "")
            {
                guna2MessageDialog1.Show("Vui lòng nhập đủ thông tin sản phẩm cần thêm", "Lỗi");
            }
            else
            {
                int soluong = int.Parse(txtSoluong);

                if (soluong > 20 || soluong == 0)
                {
                    guna2MessageDialog1.Show("Số lượng không hợp lệ (Chỉ chấp nhận lớn hơn 0 và nhỏ hơn hoặc bằng 20)", "Lỗi");
                }
                else
                {
                    bool check = bLL_Product.checkBarcode2(barcode);

                    if (check == false)
                    {
                       guna2MessageDialog1.Show("Không tìm thấy sản phẩm hoặc sản phẩm hiện tại không được kinh doanh", "Lỗi");
                    }
                    else
                    {
                        DTO_Product pro = bLL_Product.getProductBarcode(barcode);

                        bool add = bLL_Order.addProductOrderDetail(idOrder, pro.product_id, size, soluong, 0);

                        if (add)
                        {
                           guna2MessageDialog2.Show("Thêm thành công", "Thông báo");
                            this.Hide();
                        }
                        else
                        {
                            guna2MessageDialog1.Show("Thao tác không thành công", "Lỗi");
                        }

                    }
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        CancellationTokenSource cancellationToken;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Button1.Text == "Scan")
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
                videoCaptureDevice.Start();
                cancellationToken = new CancellationTokenSource();
                var sourcetoken = cancellationToken.Token;
                onStartScan(sourcetoken);
                guna2Button1.Text = "Stop";
            }
            else
            {
                guna2Button1.Text = "Scan";
                cancellationToken.Cancel();
                if (videoCaptureDevice != null)
                    if (videoCaptureDevice.IsRunning == true)
                        videoCaptureDevice.Stop();
            }
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        public void onStartScan(CancellationToken sourcetoken)
        {
            Task.Factory.StartNew(new Action(() =>
            {
                while (true)
                {
                    if (sourcetoken.IsCancellationRequested)
                    {
                        return;
                    }
                    Thread.Sleep(50);
                    BarcodeReader Reader = new BarcodeReader();
                    pictureBox1.BeginInvoke(new Action(() =>
                    {
                        if (pictureBox1.Image != null)
                        {
                            try
                            {
                                var results = Reader.DecodeMultiple((Bitmap)pictureBox1.Image);
                                if (results != null)
                                {
                                    foreach (Result result in results)
                                    {
                                        tb_barcode.Text = result.ToString();

                                        SystemSounds.Beep.Play();
                                        if (result.ResultPoints.Length > 0)
                                        {
                                            var offsetX = pictureBox1.SizeMode == PictureBoxSizeMode.Zoom
                                               ? (pictureBox1.Width - pictureBox1.Image.Width) / 2 :
                                               0;
                                            var offsetY = pictureBox1.SizeMode == PictureBoxSizeMode.Zoom
                                               ? (pictureBox1.Height - pictureBox1.Image.Height) / 2 :
                                               0;
                                            var rect = new Rectangle((int)result.ResultPoints[0].X + offsetX, (int)result.ResultPoints[0].Y + offsetY, 1, 1);
                                            foreach (var point in result.ResultPoints)
                                            {
                                                if (point.X + offsetX < rect.Left)
                                                    rect = new Rectangle((int)point.X + offsetX, rect.Y, rect.Width + rect.X - (int)point.X - offsetX, rect.Height);
                                                if (point.X + offsetX > rect.Right)
                                                    rect = new Rectangle(rect.X, rect.Y, rect.Width + (int)point.X - (rect.X - offsetX), rect.Height);
                                                if (point.Y + offsetY < rect.Top)
                                                    rect = new Rectangle(rect.X, (int)point.Y + offsetY, rect.Width, rect.Height + rect.Y - (int)point.Y - offsetY);
                                                if (point.Y + offsetY > rect.Bottom)
                                                    rect = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height + (int)point.Y - (rect.Y - offsetY));
                                            }
                                            using (var g = pictureBox1.CreateGraphics())
                                            {
                                                using (Pen pen = new Pen(Color.Green, 5))
                                                {
                                                    g.DrawRectangle(pen, rect);

                                                    pen.Color = Color.Yellow;
                                                    pen.DashPattern = new float[] { 5, 5 };
                                                    g.DrawRectangle(pen, rect);
                                                }
                                                g.DrawString(result.ToString(), new Font("Tahoma", 16f), Brushes.Blue, new Point(rect.X - 60, rect.Y - 50));
                                            }
                                        }


                                    }

                                }
                            }
                            catch (Exception ex)
                            {
                                ex.ToString();
                            }
                        }

                    }));

                }
            }), sourcetoken);
        }


        private void ThemSanPhamOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
                if (videoCaptureDevice.IsRunning == true)
                    videoCaptureDevice.Stop();
        }

        private void tb_barcode_TextChanged(object sender, EventArgs e)
        {

           string sku = tb_barcode.Text.ToString();
          //  nameProduct.Text = sku;

            
            bool check = bLL_Product.checkBarcode2(sku);

            if( check == true)
            {
                DTO_Product pro = bLL_Product.getProductBarcode(sku);
                nameProduct.Text = pro.product_name;
            }
            else
            {
                nameProduct.Text = "Không tìm thấy sản phẩm hoặc sản phẩm không được kinh doanh";
            }
          

        }
    }
}
