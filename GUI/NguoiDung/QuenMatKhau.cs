using MaterialSkin;
using MaterialSkin.Controls;
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
using DTO;

namespace GUI.NguoiDung
{
    public partial class ForgotPassword : Form
    {

        private BLL_Register bll_Register = new BLL_Register();
        private SendMail sendMail = new SendMail();

        public ForgotPassword()
        {
            InitializeComponent();
         
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

          
        }

        public String random()
        {

            string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            String otp = "";
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                otp = otp + arr[rand.Next(0, arr.Length)];
            }

            return otp;

        }

        private void ForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            String email = txt_nhapEmail.Text.ToString();

            String res = bll_Register.checkForgotPassword(email);

            if (res == "OK")
            {

                string otp = random();

                bool sMail = sendMail.sendEmail(email, otp, "Mã xác nhận đặt lại mật khẩu");
                //bool sMail = true;
                if (sMail == true)
                {
                    DateTime currentDateTime = DateTime.Now;
                    string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");


                    DTO_Staff staff = bll_Register.getInformationOfStaff(email);

                    NewPassword newPass = new NewPassword(otp, formattedDateTime, email, staff);

                    newPass.Show();
                    this.Hide();

                }
                else
                {
                   guna2MessageDialog1.Show("Gửi mã xác nhận không thành công", "Lỗi");
                }


            }
            else
            {
                guna2MessageDialog1.Show(res, "Lỗi");
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
