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
    public partial class QuanLySanPham : MaterialForm
    {

        private BLL_Product bLL_Product = new BLL_Product();
        public QuanLySanPham()
        {
            InitializeComponent();
            var skinManage = MaterialSkin.MaterialSkinManager.Instance;
            skinManage.AddFormToManage(this);
            skinManage.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManage.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green700, MaterialSkin.Primary.Green800, MaterialSkin.Primary.Green300, Accent.LightGreen700, TextShade.WHITE);

           
            textb_search.Text = "Nhập mã sản phẩm để tìm kiếm";
            textb_search.ForeColor = Color.Gray;


            dataSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataSanPham.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dataSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dataSanPham.DataSource = bLL_Product.getProductManage();

            dataSanPham.AllowUserToAddRows = false;

            dataSanPham.RowTemplate.Height = 120;


        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.LimeGreen;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.FlatAppearance.BorderSize = 0;

            btn_delete.BackColor = Color.Red;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.FlatAppearance.BorderSize = 0;

            btn_edit.BackColor = Color.Orange;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.FlatAppearance.BorderSize = 0;

            btn_refresh.BackColor = Color.LightPink;
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.FlatAppearance.BorderSize = 0;


            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_add, "Thêm sản phẩm");

            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_delete, "Xóa sản phẩm");

            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_edit, "Chỉnh sửa sản phẩm");

            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_refresh, "Refresh");



        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLySanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }



        private void textb_search_Enter(object sender, EventArgs e)
        {
           String str = textb_search.Text.ToString();

            if(str == "Nhập mã sản phẩm để tìm kiếm")
            {
                textb_search.Text = "";
            }
        }

        private void textb_search_Leave(object sender, EventArgs e)
        {
            String str = textb_search.Text.ToString();

            if( str == "")
            {
                textb_search.Text = "Nhập mã sản phẩm để tìm kiếm";
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            int row = dataSanPham.CurrentCell.RowIndex;



            String name = dataSanPham.Rows[row].Cells[2].Value.ToString();

            var confirmResult = MetroFramework.MetroMessageBox.Show(this,"Xóa " + name +" ?",
                                     "Xác nhận xóa ?",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.Yes)
            {
                String sku = dataSanPham.Rows[row].Cells[1].Value.ToString();


                bool res = bLL_Product.DisableProduct(sku);

                if (res == true)
                {
                   // dataSanPham.DataSource = bLL_Product.getProductManage();
                    dataSanPham.Rows.RemoveAt(row);
                    MetroFramework.MetroMessageBox.Show(this, "Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Đã xảy ra lỗi ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
  
           

        }

        private void textb_search_KeyDown(object sender, KeyEventArgs e)
        {

            

            if (e.KeyCode == Keys.Enter)
            {

                String key = textb_search.Text.ToString();

                if(key != "")
                {
                    DataTable dt = new DataTable();

                    dt = bLL_Product.findProduct(key);

                    if(dt.Rows.Count != 0)
                    {
                        dataSanPham.DataSource = dt;
                    }
                    else{
                        MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = bLL_Product.getProductManage();
                    dataSanPham.DataSource= dt;
                }

               
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bLL_Product.getProductManage();
            dataSanPham.DataSource = dt;    
        }


        public void refreshData()
        {
            DataTable dt = new DataTable();
            dt = bLL_Product.getProductManage();
            dataSanPham.DataSource = dt;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ThemSanPham addProduct = new ThemSanPham();
            addProduct.ShowDialog();

            refreshData();
           
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            int row = dataSanPham.CurrentCell.RowIndex;

            String barcode = dataSanPham.Rows[row].Cells[1].Value.ToString();

            SuaSanPham edit = new SuaSanPham(bLL_Product.getProductBarcode(barcode));

            edit.ShowDialog();
        }
    }
}
