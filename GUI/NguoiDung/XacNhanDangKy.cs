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
    public partial class XacNhanDangKy : Form
    {

        private DAL_Staff dalStaff = new DAL_Staff();
        public XacNhanDangKy(String email, String username, String password, String otp, String time)
        {
            InitializeComponent();

            sendEmail.Text = email;
            sendPassword.Text = password;
            sendOtp.Text = otp;
            sendUsername.Text = username;
            sendTime.Text = time;

        }

        private void XacNhanDangKy_Load(object sender, EventArgs e)
        {
       
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            String getOtp = txt_otp.Text.ToString();

            if (getOtp == "")
            {
               guna2MessageDialog1.Show("Vui lòng nhập mã xác nhận", "Lỗi");
            }
            else
            {

                DateTime now = DateTime.Now;
                DateTime send = DateTime.Parse(sendTime.Text.ToString());

                TimeSpan span = now.Subtract(send);

                int minutes = span.Minutes;

                if (!getOtp.Equals(sendOtp.Text.ToString()))
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
                         bool addNewStaff = dalStaff.addStaff(sendUsername.Text.ToString(), sendPassword.Text.ToString(), sendEmail.Text.ToString());
                      //  bool addNewStaff = true;
                        if (addNewStaff == true)
                        {
                            guna2MessageDialog2.Show("Đăng ký tài khoản thành công", "Thông báo");
                            Login lg = new Login();
                            lg.Show();
                            this.Hide();
                        }
                        else
                        {
                            guna2MessageDialog1.Show("Đăng ký tài khoản thất bại", "Lỗi");
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
    }
}
