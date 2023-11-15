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
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class Register :Form
    {

        private BLL_Register bLL_Register = new BLL_Register();
        private SendMail sendMail = new SendMail();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );
        public Register()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
            txt_password2.UseSystemPasswordChar = true;
        }

     
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CheckBox1.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
                txt_password2.UseSystemPasswordChar= false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                txt_password2.UseSystemPasswordChar = true;

            }
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
       
            String email = txt_email.Text.ToString();
            String password = txt_password.Text.ToString();
            String username = txt_username.Text.ToString();
            String confirm = txt_password2.Text.ToString();

            String result = bLL_Register.checkNewStaff(email, username, password, confirm);

            if (result == "OK")
            {
                //var confirmResult = MessageBox.Show(this, "Xác nhận tạo tài khoản ?",
                // "Xác nhận",
                //  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                DialogResult confirmResult = guna2MessageDialog2.Show( "Xác nhận tạo tài khoản ?",
                                  "Xác nhận" );

                if (confirmResult == DialogResult.Yes)
                {
                     String otp = random();
                     bool smail = sendMail.sendEmail(email, otp, "Mã xác nhận tạo tài khoản");
                    if (smail == true)
                    {
                        DateTime currentDateTime = DateTime.Now;
                        string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                        XacNhanDangKy confir = new XacNhanDangKy(email, username, password, otp, formattedDateTime);
                        confir.Show();
                        this.Hide();
                        
                    
                    }

                    else
                    {
                       guna2MessageDialog1.Show("Gửi mã xác nhận thất bại", "Lỗi");

                    }
                }
                else
                {

                }
            }
            else
            {
                guna2MessageDialog1.Show(result, "Lỗi");
            }

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
