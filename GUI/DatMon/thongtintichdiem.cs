using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
namespace GUI.DatMon
{
    public partial class thongtintichdiem : Form
    {
        private string Name;
        private int Diem;
        private int DiemSuD;
        private int TienTT;
        DTO_customer foundCustomer;
        DAL_Customer2 customers = new DAL_Customer2();



        public thongtintichdiem(int diem,string name, int tienTT, DTO_customer foundCustomer)
        {
            InitializeComponent();
            Diem = diem;
            Name = name;
            TienTT = tienTT;
            this.foundCustomer = foundCustomer;
        }
        public thongtintichdiem(int tienTT)
        {
            InitializeComponent();
            TienTT = tienTT;
        }
        public void setTT(int tienTT)
        {
            this.TienTT = tienTT;
        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thongtintichdiem_Load(object sender, EventArgs e)
        {
            label1Name.Text = Name;
            label1DiemTL.Text = Diem.ToString();
            labelQuyDoiTL.Text = (Diem*1000).ToString();
            labelCanTT.Text = TienTT.ToString();
            labelTong.Text = TienTT.ToString();
        }
        
        private void textBoxDiemSD_TextChanged(object sender, EventArgs e)
        {
            
            String a = textBoxDiemSD.Text; 
            if(a.Length > 0 && int.Parse(a) > Diem)
            {
                MessageBox.Show("Điểm sử dụng không được vượt quá điểm tích lũy!");
                btnThanhToan.Enabled = false;
            }
            else 
            {
                if(TienTT - int.Parse(a + 0)*100 <= 0)
                {
                    MessageBox.Show("Tiền giảm giá lớn hơn tiền thanh toán!");
                    btnThanhToan.Enabled = false;
                }
                else
                {
                    int DiemSD = int.Parse(a + 0);
                    labelQuyDoiSD.Text = (DiemSD * 100).ToString();
                    DiemSuD = DiemSD / 10;
                    labelGIamGia.Text = (DiemSuD * 1000).ToString();
                    labelTong.Text = (TienTT - DiemSD*100).ToString();
                    btnThanhToan.Enabled = true;
                }
                
            }
           
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            thanhtoan tt = new thanhtoan(TienTT - DiemSuD * 1000);
            customers.updateTichdiem((int)foundCustomer.customer_Id, (int)foundCustomer.customer_tichdiem + 1 - DiemSuD);
            tt.Show();
            this.Close();
        }
    }
}
