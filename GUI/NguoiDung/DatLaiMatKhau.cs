using BLL;
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
using DTO;

namespace GUI.NguoiDung
{
    public partial class NewPassword :Form
    {

        private DAL_Staff dAL_Staff = new DAL_Staff();
        private BLL_Register bLL_Register = new BLL_Register();
        public NewPassword(String otp, String time,String email, DTO_Staff staff)
        {
            InitializeComponent();

            sendOtp.Text = otp;
            sendTime.Text = time;
            sendEmail.Text = email;

            string username = staff.username;

        }

        private void DatLaiMatKhau_Load(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
         }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String getOtp = otp.Text.ToString();

            String getNewPassword = password.Text.ToString();

            String sOtp = sendOtp.Text.ToString();

            DateTime now = DateTime.Now;
            DateTime send = DateTime.Parse(sendTime.Text.ToString());

            TimeSpan span = now.Subtract(send);

            int minutes = span.Minutes;

            if (getOtp == "" || getNewPassword == "")
            {
               guna2MessageDialog1.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                if (!getOtp.Equals(sOtp))
                {
                   guna2MessageDialog1.Show("Mã xác nhận không chính xác", "Lỗi");
                }
                else
                {

                    if (minutes > 3)
                    {
                       guna2MessageDialog1.Show("Mã xác nhận đã hết hiệu lực", "Thông báo");
                    }
                    else
                    {


                        bool checkPass = bLL_Register.checkPassword(getNewPassword);

                        if (checkPass == true)
                        {
                            bool setNewPass = dAL_Staff.UpdatePassword(sendEmail.Text.ToString(), getNewPassword);

                            if (setNewPass == true)
                            {
                                guna2MessageDialog2.Show("Đặt lại mật khẩu thành công", "Thông báo");
                                Login lg = new Login();
                                lg.Show();
                                this.Hide();
                            }
                            else
                            {
                                guna2MessageDialog1.Show("Đặt lại mật khẩu thất bại", "Lỗi");
                            }

                        }
                        else
                        {
                            guna2MessageDialog1.Show("Mật khẩu không đủ độ phức tạp. Vui lòng thử lại mật khẩu khác", "Thông báo");
                        }

                    }
                }
            }
        }

        private void otp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void cb_showpasss_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpasss.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void title_login_MouseHover(object sender, EventArgs e)
        {
            title_login.ForeColor = Color.Red;
        }

        private void title_login_MouseLeave(object sender, EventArgs e)
        {
            title_login.ForeColor = Color.Black;
        }

        private void title_login_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
