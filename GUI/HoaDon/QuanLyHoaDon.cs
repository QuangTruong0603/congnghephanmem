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

            databill.DataSource = bLL_Bill.getAllBill();
            databill.AllowUserToAddRows = false;


        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {

           


        }

        private void QuanLyHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
   
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
         

        }

        private void btn_detail_Click(object sender, EventArgs e)
        {



        }

        private void textb_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_detail_Click_1(object sender, EventArgs e)
        {
            int row = databill.CurrentCell.RowIndex;

            String nobill = databill.Rows[row].Cells[1].Value.ToString();




            ChiTietHoaDon cthd = new ChiTietHoaDon(nobill);
            cthd.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DataTable dt = bLL_Bill.getAllBill();
            databill.DataSource = dt;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                String key = txt_search.Text.ToString();

                if (key != "")
                {
                    DataTable dt = new DataTable();
                    dt = bLL_Bill.getOneBill(key);
                    if (dt.Rows.Count == 0)
                    {
                        guna2MessageDialog1.Show("Không tìm thấy hóa đơn", "Lỗi");

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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
