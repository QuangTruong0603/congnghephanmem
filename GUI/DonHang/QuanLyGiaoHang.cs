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


            dataAll.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataAll.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data0.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data0.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_refresh, "Refresh");

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyGiaoHang_Load(object sender, EventArgs e)
        {
            textb_search.Text = "Nhập mã đơn hàng để tìm kiếm";
            textb_search.ForeColor = Color.Gray;


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
            catch(Exception ex) { }
          
        }

        public void EditOrder()
        {
            ChinhSuaDonHang edit = new ChinhSuaDonHang(idOrder);
            edit.ShowDialog();
            refresh();
        }


        private void dataAll_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                showMenu(e,dataAll);
            }



        }


        public void refresh()
        {
            dataAll.DataSource = bLL_Order.getAllOrder();
            data0.DataSource = bLL_Order.getOrderByStatus("Chờ lấy hàng");
            data1.DataSource = bLL_Order.getOrderByStatus("Đang vận chuyển");
            data2.DataSource = bLL_Order.getOrderByStatus("Đang giao cho khách hàng");
            data3.DataSource = bLL_Order.getOrderByStatus("Đã giao thành công");
        }



        public void ShowDetails()
        {
            ChiTietDonHang ctdh = new ChiTietDonHang(idOrder);
            ctdh.ShowDialog();
        }

        public void PrintOrder()
        {
            Dictionary<string, string> dic  = new Dictionary<string, string>();
            dic = bLL_Order.getOrderById(idOrder);

            List<DTO_BillDetail> list = bLL_Order.getListProductOfOrder(idOrder);

           // Console.WriteLine(list.Count());

            PrintReview prt = new PrintReview(dic,idOrder,list);

            prt.ShowDialog();

        }

        public void DeleteOrder()
        {
            if(status == "Chờ lấy hàng" || status == "Đang vận chuyển" || status == "Đang giao cho khách hàng")
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn hủy đơn hàng ??",
                                     "Xác nhận hủy đơn hàng",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bool check = bLL_Order.deleteOrder(idOrder);

                    if (check)
                    {
                        MessageBox.Show("Hủy đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Hủy đơn hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Không thể hủy đơn hàng","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void data0_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                showMenu(e,data0);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textb_search_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textb_search_Enter(object sender, EventArgs e)
        {
            String str = textb_search.Text.ToString();

            if (str == "Nhập mã đơn hàng để tìm kiếm")
            {
                textb_search.Text = "";
            }
        }

        private void textb_search_Leave(object sender, EventArgs e)
        {
            String str = textb_search.Text.ToString();

            if (str == "")
            {
                textb_search.Text = "Nhập mã đơn hàng để tìm kiếm";
            }
        }

   

        private void textb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tabControl1.SelectedIndex = 0;


                string s = textb_search.Text.ToString();

                if(s == "")
                {
                    MessageBox.Show("Vui lòng nhập mã đơn hàng để tìm kiếm","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int idSearch = int.Parse(s);

                    
                    DataTable dt = new DataTable();

                    dt = bLL_Order.getOneOrderById(idSearch);

                    int count = dt.Rows.Count;

                    if(count == 0)
                    {
                        MessageBox.Show("Không tìm thấy đơn hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dataAll.DataSource = dt;
                    }

                }
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ManHinhChinh main = new ManHinhChinh();
            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
