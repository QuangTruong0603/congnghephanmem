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
    public partial class thanhtoan : Form
    {
        private int TienTT;
        public thanhtoan(int tt)
        {
            InitializeComponent();
            TienTT = tt;
        }

       

        private void thanhtoan_Load(object sender, EventArgs e)
        {
            labelCanThanhToan.Text = TienTT.ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if(textBox1.Text.Length > 0 )
            {
                labelDua.Text = textBox1.Text;
                labelTra.Text = ( int.Parse(textBox1.Text)-TienTT).ToString();
            }
            
        }
    }
}
