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

namespace GUI
{
    public partial class Register : MaterialForm
    {

        private BLL_Register bLL_Register = new BLL_Register();
        private SendMail sendMail = new SendMail();
        public Register()
        {
            InitializeComponent();
            var skinManage = MaterialSkin.MaterialSkinManager.Instance;
            skinManage.AddFormToManage(this);
            skinManage.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManage.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green700, MaterialSkin.Primary.Green800, MaterialSkin.Primary.Green300, Accent.LightGreen700, TextShade.WHITE);
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txt_titleEmail.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 14);
            txt_titleTaiKhoan.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 14);
            txt_titleMatkhau.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 14);
            txt_tittleConfirm.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 14);
        }

     
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void ch_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(ch_showpass.Checked == true)
            {
                txt_password.Password = false;
                txt_confirmpassword.Password = false;
            }
            else
            {
                txt_password.Password = true;
                txt_confirmpassword.Password = true;
            }
        }


        public String random()
        {

            string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            String otp = "";
            Random rand = new Random();
            for (int i = 0; i<6; i++)
            {
                otp = otp + arr[rand.Next(0,arr.Length)];
            }

            return otp;

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            String email = txt_email.Text.ToString();
            String password = txt_password.Text.ToString();
            String username = txt_username.Text.ToString();
            String confirm = txt_confirmpassword.Text.ToString();

            String result = bLL_Register.checkNewStaff(email, username, password, confirm);

            if(result == "OK")
            {
                var confirmResult = MessageBox.Show("Xác nhận tạo tài khoản ?",
                                  "Xác nhận",
                                  MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    String otp = random();
                   // bool smail = sendMail.sendEmail(email, otp);
                    bool smail = true;
                    if (smail == true)
                    {
                        DateTime currentDateTime = DateTime.Now;
                        string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                        XacNhanDangKy confir = new XacNhanDangKy(email,username,password,otp,formattedDateTime);
                        confir.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Gửi mã xác nhận thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            Login lg = new Login();
            lg.Show();
            Visible = false; ;
        }
    }
}
