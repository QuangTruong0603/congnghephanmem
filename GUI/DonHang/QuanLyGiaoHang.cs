using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;
using GUI.DonHang;

namespace GUI
{
    public partial class QuanLyGiaoHang : Form
    {
        private BLL_Order bLL_Order = new BLL_Order();

        private int  idOrder;
        private string status;

        public QuanLyGiaoHang()
        {
            InitializeComponent();


        
        }

       
        private void QuanLyGiaoHang_Load(object sender, EventArgs e)
        {
            dataAll.DataSource = bLL_Order.getAllOrder();
            dataAll.AllowUserToAddRows = false;


            data0.DataSource = bLL_Order.getOrderByStatus("Chờ lấy hàng");
            data0.AllowUserToAddRows = false;

            data1.DataSource = bLL_Order.getOrderByStatus("Đang vận chuyển");
            data1.AllowUserToAddRows = false;

            data2.DataSource = bLL_Order.getOrderByStatus("Đang giao cho khách hàng");
            data2.AllowUserToAddRows = false;

            data3.DataSource = bLL_Order.getOrderByStatus("Đã giao thành công");
            data3.AllowUserToAddRows = false;
        }


        public void showMenu(MouseEventArgs e, DataGridView dataAll)
        {

            try
            {
                int currentMouseOverRow = dataAll.HitTest(e.X, e.Y).RowIndex;

                int row = int.Parse(currentMouseOverRow.ToString());


                idOrder = int.Parse(dataAll.Rows[row].Cells[1].Value.ToString());
                status = dataAll.Rows[row].Cells[6].Value.ToString();

                //Console.WriteLine(idOrder);

                ContextMenu m = new ContextMenu();
                m.MenuItems.Add("Thông tin chi tiết", (s, args) => { ShowDetails(); });
                m.MenuItems.Add(new MenuItem("Chỉnh sửa đơn", (s, args) => { EditOrder(); }));
                m.MenuItems.Add(new MenuItem("In đơn", (s, args) => { PrintOrder(); }));
                m.MenuItems.Add(new MenuItem("Hủy đơn", (s, args) => { DeleteOrder(); }));



                m.Show(dataAll, new Point(e.X, e.Y));

            }
            catch (Exception ex) { }

        }
        public void refresh()
        {
            dataAll.DataSource = bLL_Order.getAllOrder();
            data0.DataSource = bLL_Order.getOrderByStatus("Chờ lấy hàng");
            data1.DataSource = bLL_Order.getOrderByStatus("Đang vận chuyển");
            data2.DataSource = bLL_Order.getOrderByStatus("Đang giao cho khách hàng");
            data3.DataSource = bLL_Order.getOrderByStatus("Đã giao thành công");
        }


        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataAll_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                showMenu(e, dataAll);
            }
        }

        private void data0_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                showMenu(e, data0);
            }
        }

        private void data1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                showMenu(e, data1);
            }
        }

        private void data2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                showMenu(e, data2);
            }
        }

        private void data3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                showMenu(e, data3);
            }
        }

        public void ShowDetails()
        {
            ChiTietDonHang ctdh = new ChiTietDonHang(idOrder);
            ctdh.ShowDialog();
        }

        public void PrintOrder()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic = bLL_Order.getOrderById(idOrder);

            List<DTO_BillDetail> list = bLL_Order.getListProductOfOrder(idOrder);

            // Console.WriteLine(list.Count());

            PrintReview prt = new PrintReview(dic, idOrder, list);

            prt.ShowDialog();

        }

        public void DeleteOrder()
        {
            if (status == "Chờ lấy hàng" || status == "Đang vận chuyển" || status == "Đang giao")
            {
                var confirmResult = guna2MessageDialog2.Show("Bạn có chắc muốn hủy đơn hàng ??",
                                     "Xác nhận hủy đơn hàng");
                if (confirmResult == DialogResult.Yes)
                {
                    bool check = bLL_Order.deleteOrder(idOrder);

                    if (check)
                    {
                       guna2MessageDialog3.Show("Hủy đơn hàng thành công", "Thông báo");
                        refresh();
                    }
                    else
                    {
                      guna2MessageDialog1.Show("Hủy đơn hàng thất bại", "Lỗi");
                    }
                }
                else
                {

                }
            }
            else
            {
                guna2MessageDialog1.Show("Không thể hủy đơn hàng", "Lỗi");
            }
        }

        public void EditOrder()
        {
            ChinhSuaDonHang edit = new ChinhSuaDonHang(idOrder);
            edit.ShowDialog();
            refresh();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void textb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ddd.SelectedIndex = 0;


                string s = textb_search.Text.ToString();

                if (s == "")
                {
                   guna2MessageDialog1.Show("Vui lòng nhập mã đơn hàng để tìm kiếm", "Lỗi");
                }
                else
                {
                    int idSearch = int.Parse(s);


                    DataTable dt = new DataTable();

                    dt = bLL_Order.getOneOrderById(idSearch);

                    int count = dt.Rows.Count;

                    if (count == 0)
                    {
                        guna2MessageDialog1.Show("Không tìm thấy đơn hàng", "Lỗi");
                    }
                    else
                    {
                        dataAll.DataSource = dt;
                    }

                }
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
