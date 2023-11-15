using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.IO;

namespace GUI.SanPham
{
    public partial class QuanLySanPham : Form
    {

        private BLL_Product bLL_Product = new BLL_Product();
        public QuanLySanPham()
        {
            InitializeComponent();

            dataSanpham.DataSource = bLL_Product.getProductManage();

            dataSanpham.AllowUserToAddRows = false;

            dataSanpham.RowTemplate.Height = 120;
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            cb_filter.SelectedIndex = 0;

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ThemSanPham addProduct = new ThemSanPham();
            addProduct.ShowDialog();

            refreshData();
        }

        public void refreshData()
        {
            cb_filter.SelectedIndex = 0;
            DataTable dt = new DataTable();
            dt = bLL_Product.getProductManage();
            dataSanpham.DataSource = dt;
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                String key = txt_search.Text.ToString();

                if (key != "")
                {
                    DataTable dt = new DataTable();

                    dt = bLL_Product.findProduct(key);

                    if (dt.Rows.Count != 0)
                    {
                        cb_filter.SelectedIndex = 0;

                        dataSanpham.DataSource = dt;
                    }
                    else
                    {
                       

                        guna2MessageDialog1.Show( "Không tìm thấy sản phẩm", "Lỗi");
                    }
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = bLL_Product.getProductManage();
                    dataSanpham.DataSource = dt;
                }


            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int row = dataSanpham.CurrentCell.RowIndex;

            String barcode = dataSanpham.Rows[row].Cells[1].Value.ToString();

            SuaSanPham edit = new SuaSanPham(bLL_Product.getProductBarcode(barcode));

            edit.ShowDialog(this);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int row = dataSanpham.CurrentCell.RowIndex;



            String name = dataSanpham.Rows[row].Cells[2].Value.ToString();

            var confirmResult = guna2MessageDialog2.Show("Xóa " + name + " ?",
                                     "Xác nhận xóa ?"  );
            if (confirmResult == DialogResult.Yes)
            {
                String sku = dataSanpham.Rows[row].Cells[1].Value.ToString();


                bool res = bLL_Product.DisableProduct(sku);

                if (res == true)
                {
                    // dataSanPham.DataSource = bLL_Product.getProductManage();
                  //  dataSanpham.Rows.RemoveAt(row);
                   guna2MessageDialog3.Show("Đã xóa thành công", "Thông báo");
                    refreshData();

                }
                else
                {
                    guna2MessageDialog1.Show("Đã xảy ra lỗi ", "Lỗi");
                }

            }

        }

        private void sanPhamKinhDoanh()
        {
            DataTable dt = new DataTable();
            dt = bLL_Product.getProductManageKD();
            dataSanpham.DataSource = dt;
        }
        private void sanPhamKoKinhDoanh()
        {
            DataTable dt = new DataTable();
            dt = bLL_Product.getProductManageKKD();
            dataSanpham.DataSource = dt;
        }

        private void sanPhamAll()
        {
            DataTable dt = new DataTable();
            dt = bLL_Product.getProductManage();
            dataSanpham.DataSource = dt;
        }





        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cb_filter.Text.ToString();

            if(s== "Đang kinh doanh")
            {
                sanPhamKinhDoanh();
            }

            if (s == "Không kinh doanh")
            {
                sanPhamKoKinhDoanh();
            }

            if (s == "Tất cả")
            {
                sanPhamAll();
            }

        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
            int row = dataSanpham.CurrentCell.RowIndex;
            String sku = dataSanpham.Rows[row].Cells[1].Value.ToString();


            var confirmResult = guna2MessageDialog2.Show("Thực hiện thao tác ?",
                                    "Xác nhận ?");

            if(confirmResult == DialogResult.Yes)
            {
                bool c = bLL_Product.enableproduct(sku);

                if (c == true)
                {
                    refreshData();
                    guna2MessageDialog3.Show("Thành công ", "Thông báo");
                }
                else
                {
                    guna2MessageDialog1.Show("Đã xảy ra lỗi", "Lỗi");
                }
            }

            

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
