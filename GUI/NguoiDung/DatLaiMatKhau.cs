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

            this.Text = "Đặt lại mật khẩu cho " + username ;

            txt_titleOtp.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 14);
            txt_titlePassword.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 14);
            waring.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 10);
            waring.ForeColor = Color.Red;


        }

        private void DatLaiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void ch_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ch_showPass.Checked == true)
            {
                password.Password = false;
            }
            else
            {
                password.Password  = true;
            }
        }




        private void btn_createNewPass_Click(object sender, EventArgs e)
        {
            String getOtp = otp.Text.ToString();

            String getNewPassword = password.Text.ToString(); 
            
            String sOtp = sendOtp.Text.ToString();

            DateTime now = DateTime.Now;
            DateTime send = DateTime.Parse(sendTime.Text.ToString());

            TimeSpan span = now.Subtract(send);

            int minutes = span.Minutes;

            if (getOtp == "" ||  getNewPassword == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!getOtp.Equals(sOtp))
                {
                    MessageBox.Show("Mã xác nhận không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (minutes > 3)
                    {
                        MessageBox.Show( "Mã xác nhận đã hết hiệu lực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else{


                        bool checkPass = bLL_Register.checkPassword(getNewPassword);

                        if (checkPass == true)
                        {
                            bool setNewPass = dAL_Staff.UpdatePassword(sendEmail.Text.ToString(), getNewPassword);

                            if (setNewPass == true)
                            {
                                MessageBox.Show("Đặt lại mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Login lg = new Login();
                                lg.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Đặt lại mật khẩu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không đủ độ phức tạp. Vui lòng thử lại mật khẩu khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }

        }

        private void otp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
