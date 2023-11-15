using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
namespace GUI.DatMon
{
    public partial class DangNhapTichDiem : Form
    {
        private int TongTT;
        public DangNhapTichDiem(int tongTT)
        {
            InitializeComponent();
            TongTT = tongTT;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string phone = textBoxPhone.Text;
            DAL_Customer2 customers = new DAL_Customer2();
            List<DTO_customer> customerList = customers.GetProducts();



            DTO_customer foundCustomer = customerList.FirstOrDefault(cust => cust.customer_phone == phone);

            if (foundCustomer != null)
            {
                
               
                thongtintichdiem t = new thongtintichdiem((int)foundCustomer.customer_tichdiem+1, foundCustomer.customer_name,TongTT,foundCustomer);
                t.Show();
                
                this.Hide();


            }
            else
            {
                
                MessageBox.Show("Phone doesn't exist in the customer records.");
            }
        }

        private void DangNhapTichDiem_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            TichDiem tichDiem = new TichDiem(TongTT);

            tichDiem.Show();
            this.Hide();
        }
    }
}
