using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using DTO;


namespace GUI
{
    public partial class ChiTietHoaDon : Form
    {

        private string nobill;

        private BLL_Bill bLL_Bill = new BLL_Bill();
        public ChiTietHoaDon(String nobill)
        {
            InitializeComponent();
            this.nobill = nobill;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {

            btn_export.BackColor = Color.Orange;
            btn_export.FlatStyle = FlatStyle.Flat;
            btn_export.FlatAppearance.BorderSize = 0;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_export, "In hóa đơn");

            title.Text = "CHI TIẾT HÓA ĐƠN: " + nobill;

            Dictionary<string, string> dir = bLL_Bill.getBillByNoBill(nobill);

            foreach (KeyValuePair<string, string> item in dir)
            {
                if (item.Key.Equals("bill_date"))
                {
                    txt_date.Text = item.Value;

                }


                if (item.Key.Equals("bill_total_after"))
                {
                    txt_lprice.Text = item.Value +" VND";

                }

                if (item.Key.Equals("bill_total_before"))
                {
                    txt_fprice.Text = item.Value + " VND";

                }

                if (item.Key.Equals("paymentmethod_name"))
                {
                    txt_method.Text = item.Value;

                }


                if (item.Key.Equals("staff_name"))
                {
                    txt_staff.Text = item.Value;

                }


            }

            string customer = bLL_Bill.getCustomerOfBill(nobill);

            txt_customer.Text = customer;


            datagridview.AllowUserToAddRows = false;

            DataTable data = bLL_Bill.getDetailProBill(nobill);
            datagridview.DataSource = data;


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_customer_Click(object sender, EventArgs e)
        {

        }

        private void btn_export_Click(object sender, EventArgs e)
        {

            List<string> list = new List<string>();
            list.Add(nobill);
            list.Add(txt_staff.Text.ToString());
            list.Add(txt_customer.Text.ToString());
            list.Add(txt_date.Text.ToString());
            list.Add(txt_fprice.Text.ToString());
            list.Add(txt_lprice.Text.ToString());
            list.Add(txt_method.Text.ToString());

            List<DTO_BillDetail> l = new List<DTO_BillDetail>();

            foreach (DataGridViewRow row in datagridview.Rows)
            {
               DTO_BillDetail tmp = new DTO_BillDetail();
                tmp.barcode = row.Cells[2].Value.ToString();
                tmp.namepro = row.Cells[1].Value.ToString();
                tmp.quatity = int.Parse(row.Cells[3].Value.ToString());
                tmp.size = row.Cells[4].Value.ToString();
                tmp.price = int.Parse(row.Cells[5].Value.ToString());

                l.Add(tmp);
            }

            Form rp = new ReportView(list,l);
            rp.ShowDialog();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
