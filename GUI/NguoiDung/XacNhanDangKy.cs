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
using DAL;
using GUI.NguoiDung;

namespace GUI
{
    public partial class XacNhanDangKy : MaterialForm
    {

        private DAL_Staff dalStaff = new DAL_Staff();
        public XacNhanDangKy(String email, String username, String password, String otp, String time)
        {
            InitializeComponent();
            var skinManage = MaterialSkin.MaterialSkinManager.Instance;
            skinManage.AddFormToManage(this);
            skinManage.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManage.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green700, MaterialSkin.Primary.Green800, MaterialSkin.Primary.Green300, Accent.LightGreen700, TextShade.WHITE);



            sendEmail.Text = email;
            sendPassword.Text = password;
            sendOtp.Text = otp;
            sendUsername.Text = username;
            sendTime.Text = time;
        }

        private void XacNhanDangKy_Load(object sender, EventArgs e)
        {
            txt_title.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 20);
            warning.ForeColor = Color.Red;
           


        }

        private void txt_title_Click(object sender, EventArgs e)
        {

        }

        private void txt_otp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            String getOtp = txt_otp.Text.ToString();

            if(getOtp == "")
            {
                MessageBox.Show("Vui lòng nhập mã xác nhận", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DateTime now = DateTime.Now;
                DateTime send = DateTime.Parse(sendTime.Text.ToString());

                TimeSpan span = now.Subtract(send);

                int minutes = span.Minutes;

                if (!getOtp.Equals(sendOtp.Text.ToString()))
                {
                    MessageBox.Show("Mã xác nhận không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(minutes >3)
                    {
                        MessageBox.Show("Mã xác nhận đã hết hiệu lực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bool addNewStaff = dalStaff.addStaff(sendUsername.Text.ToString(), sendPassword.Text.ToString(), sendEmail.Text.ToString());

                        if(addNewStaff == true)
                        {
                            MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login lg = new Login();
                            lg.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký tài khoản thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }



            
        }

        private void XacNhanDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Register fgpass = new Register();
            fgpass.Show();
            this.Visible = false;
        }

        private void txt_otp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
