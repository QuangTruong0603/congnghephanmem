using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DatMon
{
    public partial class TichDiem : Form
    {
        private int tong;
        public TichDiem(int tong)
        {
            InitializeComponent();
            this.tong = tong;
        }

        private void TichDiem_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phone = textBox1.Text;
            DAL_Customer2 customers = new DAL_Customer2();
            List<DTO_customer> customerList = customers.GetProducts();



            DTO_customer foundCustomer = customerList.FirstOrDefault(cust => cust.customer_phone == phone);
            if (foundCustomer == null) 
            {
                DAL_Customer2 dAL_Customer2 = new DAL_Customer2();
                dAL_Customer2.AddCustomer(textBox1.Text.ToString(), textBox2.Text.ToString());
                this.Close();
                DangNhapTichDiem dn = new DangNhapTichDiem(tong);
                dn.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                this.Close();
                DangNhapTichDiem dn = new DangNhapTichDiem(tong);
                dn.Show();
            }
           
            
        }
    }
}
