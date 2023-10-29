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

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Ảnh"; 
            dataSanPham.Columns.Add(imageColumn); 




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
    }
}
