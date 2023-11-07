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
using MaterialSkin;
using MaterialSkin.Controls;


namespace GUI
{
    public partial class QuanLyHoaDon : Form
    {

        private BLL_Bill bLL_Bill = new BLL_Bill();
        public QuanLyHoaDon()
        {
            InitializeComponent();
        

            databill.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            databill.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            databill.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            databill.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            databill.DataSource = bLL_Bill.getAllBill();

            databill.AllowUserToAddRows = false;

            databill.RowTemplate.Height = 120;

            label1.Font = new Font("Arial", 24, FontStyle.Bold);

        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {

            textb_search.Text = "Nhập mã hóa đơn để tìm kiếm";
            textb_search.ForeColor = Color.Gray;


            btn_detail.BackColor = Color.Green;
            btn_detail.FlatStyle = FlatStyle.Flat;
            btn_detail.FlatAppearance.BorderSize = 0;


            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.FlatAppearance.BorderSize = 0;

            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.btn_detail, "Xem chi tiết");

            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.btn_refresh, "Refresh");




        }

        private void QuanLyHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
         

        }

        private void btn_detail_Click(object sender, EventArgs e)
        {



            int row = databill.CurrentCell.RowIndex;

            String nobill = databill.Rows[row].Cells[1].Value.ToString();


            

            ChiTietHoaDon cthd = new ChiTietHoaDon(nobill);
            cthd.ShowDialog();
        }

        private void textb_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textb_search_Enter(object sender, EventArgs e)
        {
            String str = textb_search.Text.ToString();

            if (str == "Nhập mã hóa đơn để tìm kiếm")
            {
                textb_search.Text = "";
            }
        }

        private void textb_search_Leave(object sender, EventArgs e)
        {
            String str = textb_search.Text.ToString();

            if (str == "")
            {
                textb_search.Text = "Nhập mã hóa đơn để tìm kiếm";
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
                    dt = bLL_Bill.getOneBill(key);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        databill.DataSource = dt;
                    }

                }
                else
                {
                    DataTable dt = bLL_Bill.getAllBill();
                    databill.DataSource = dt;
                }
                        
               

            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DataTable dt = bLL_Bill.getAllBill();
            databill.DataSource = dt;
        }
    }
}
