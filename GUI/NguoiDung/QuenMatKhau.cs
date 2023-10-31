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
    public partial class ForgotPassword : MaterialForm
    {

        private BLL_Register bll_Register = new BLL_Register();
        private SendMail sendMail = new SendMail();

        public ForgotPassword()
        {
            InitializeComponent();
            var skinManage = MaterialSkin.MaterialSkinManager.Instance;
            skinManage.AddFormToManage(this);
            skinManage.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManage.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green700, MaterialSkin.Primary.Green800, MaterialSkin.Primary.Green300, Accent.LightGreen700, TextShade.WHITE);
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

            txt_nhapEmail.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif),16);
        }

        private void ForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
           Environment.Exit(0);
           Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void btn_next_Click(object sender, EventArgs e)
        {
            String email = txtB_email.Text.ToString();

            String res = bll_Register.checkForgotPassword(email);

            if(res == "OK")
            {

                string otp = random();

                 bool sMail = sendMail.sendEmail(email, otp, "Mã xác nhận đặt lại mật khẩu");
                 //bool sMail = true;
                if (sMail == true)
                {
                    DateTime currentDateTime = DateTime.Now;
                    string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");


                    DTO_Staff staff = bll_Register.getInformationOfStaff(email);

                    NewPassword newPass     = new NewPassword(otp,formattedDateTime,email,staff);

                    newPass.Show();
                    this.Hide();

                }
                else{
                    MessageBox.Show("Gửi mã xác nhận không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else{
                MessageBox.Show(res, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Visible = false;
        }
    }
}
