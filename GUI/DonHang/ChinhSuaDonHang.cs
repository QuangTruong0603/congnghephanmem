using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.DonHang
{
    public partial class ChinhSuaDonHang : Form
    {
        private BLL_Product bLL_Product = new BLL_Product();
        private BLL_Order bLL_Order = new BLL_Order();
        private int idOrder;
        private string barcode;

        public ChinhSuaDonHang(int idOrder)
        {
            InitializeComponent();
            this.cb_trangthaidonhang.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_thanhtoan.DropDownStyle = ComboBoxStyle.DropDownList;
            this.idOrder = idOrder;

            dataDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataDetail.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataDetail.AllowUserToAddRows = false;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void loadData()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic = bLL_Order.getOrderById(idOrder);

            int fprice = 0;
            int lprice = 0;

            foreach (KeyValuePair<string, string> item in dic)
            {



                if (item.Key.Equals("madonhang"))
                {
                    title.Text = "Mã đơn hàng: " + item.Value;

                }


                if (item.Key.Equals("tennguoinhan"))
                {
                    tb_tengnuoinhan.Text = item.Value;

                }

                if (item.Key.Equals("diachi"))
                {
                    tb_diachi.Text = item.Value;
                }

                if (item.Key.Equals("sdt"))
                {
                    tb_sdt.Text = item.Value;
                }

                if (item.Key.Equals("sotien"))
                {
                    tb_eprice.Text = item.Value + " VND";

                    lprice = int.Parse(item.Value.ToString());
                }


                if (item.Key.Equals("trangthai"))
                {
                    cb_trangthaidonhang.SelectedIndex = cb_trangthaidonhang.FindStringExact(item.Value);
                }

                if (item.Key.Equals("thanhtoan"))
                {
                    cb_thanhtoan.SelectedIndex = cb_thanhtoan.FindStringExact(item.Value);
                }


                if (item.Key.Equals("tkdh"))
                {
                    tb_customer.Text = item.Value;
                }

                if (item.Key.Equals("sdttkdh"))
                {
                    tb_customer.Text = tb_customer.Text + "-" + item.Value;
                }

                if (item.Key.Equals("ngaytaodon"))
                {
                    tb_date.Text = item.Value;
                }

                if (item.Key.Equals("sotienbandau"))
                {
                    tb_fprice.Text = item.Value + " VND";
                    fprice = int.Parse(item.Value.ToString());
                }



            }

            int delivery = lprice - fprice;

            tb_phivanchuyen.Text = delivery.ToString();


            dataDetail.DataSource = bLL_Order.getOrderDetailById(idOrder);
        }

        private void ChinhSuaDonHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void showMenu(MouseEventArgs e, DataGridView dataAll)
        {

            try
            {
                int currentMouseOverRow = dataAll.HitTest(e.X, e.Y).RowIndex;

                int row = int.Parse(currentMouseOverRow.ToString());


                barcode = dataAll.Rows[row].Cells[1].Value.ToString();

                //Console.WriteLine(idOrder);

                ContextMenu m = new ContextMenu();
                m.MenuItems.Add("Xóa sản phẩm", (s, args) => { deleteProductOrder(); });
            

                m.Show(dataAll, new Point(e.X, e.Y));

            }
            catch (Exception ex) { }

        }



        public void deleteProductOrder()
        {

            DTO_Product pro = bLL_Product.getProductBarcode(barcode);

            var confirmResult = guna2MessageDialog3.Show("Bạn chắc chắn muốn xóa ??",
                                     "Xác nhận xóa");
            if (confirmResult == DialogResult.Yes)
            {

                bool delete = bLL_Order.deleteProductOrderDetail( idOrder, pro.product_id);

                if (delete)
                {
                   guna2MessageDialog2.Show("Xóa thành công", "Thông báo");
                    loadData();
                }
                else
                {
                  guna2MessageDialog2.Show("Thao tác thất bại", "lỗi");
                }
            }
            else
            {

            }


        }



        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string tennguoinhan = tb_tengnuoinhan.Text;
            string diachi = tb_diachi.Text;
            string sdt = tb_sdt.Text;
            string  phivanchuyen = tb_phivanchuyen.Text;
            string trangthai = cb_trangthaidonhang.Text.ToString();
            string thanhtoan = cb_thanhtoan.Text.ToString();

            if(tennguoinhan =="" || diachi =="" || sdt == "")
            {
                guna2MessageDialog1.Show("Vui lòng nhập đủ thông tin", "Lỗi");

            }
            else
            {
                int delivery = 0;
                if(phivanchuyen != "")
                {
                    delivery = int.Parse(phivanchuyen);
                }

                if(sdt.Length != 10)
                {
                    guna2MessageDialog1.Show("Số điện thoại không hợp lệ", "Lỗi");
                }
                else
                {
                    bool update = bLL_Order.updateOrder(idOrder, tennguoinhan, diachi, sdt, trangthai, thanhtoan, delivery);

                    if (update)
                    {
                        guna2MessageDialog2.Show("Cập nhật thông tin thành công", "Thông báo");
                        this.Hide();
                    }
                    else
                    {
                            guna2MessageDialog1.Show("Thao tác thất bại", "lỗi");
                    }
                }
            }



        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemSanPhamOrder add = new ThemSanPhamOrder(idOrder);
            add.ShowDialog();
            loadData();
        }

  

        private void tb_sdt_TextChange(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataDetail_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                showMenu(e, dataDetail);
            }
        }
    }
}
