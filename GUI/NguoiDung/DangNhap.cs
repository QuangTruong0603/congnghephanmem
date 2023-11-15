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
using GUI.NguoiDung;
using System.Runtime.InteropServices;

namespace GUI
{

    public partial class Login : Form
    {

        private BLL_Login_Staff bLL_Login_Staff = new BLL_Login_Staff();
        private Panel borderedPanel;
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
        public Login()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
        }

       

        private void DangNhap_Load(object sender, EventArgs e)
        {
               
                txt_password.UseSystemPasswordChar = true;
        }

      
     
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
          Environment.Exit(0);
          Application.Exit();
        }



        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            Visible = false;
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar =  true;
            }
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_forgetPassword_MouseHover(object sender, EventArgs e)
        {
            txt_forgetPassword.ForeColor = Color.Red;
        }

        private void txt_forgetPassword_MouseLeave(object sender, EventArgs e)
        {
            txt_forgetPassword.ForeColor = Color.Black;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username = txt_usename.Text.ToString();
            String password = txt_password.Text.ToString();

            String result = bLL_Login_Staff.checkLogin(username, password);

            if (result == "Thành công")
            {
                int roleid = bLL_Login_Staff.getRole(username);
                string staffname = bLL_Login_Staff.getName(username);
                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");

                string rolename = bLL_Login_Staff.getRoleName(username);

                DTO_Staff st = bLL_Login_Staff.GetStaff(username);

                //Properties.Settings.Default.username = username;
                //Properties.Settings.Default.name = staffname;
                //Properties.Settings.Default.roleid = roleid;
                //Properties.Settings.Default.timelogin = formattedDateTime;
                //Properties.Settings.Default.Save();

                Account.username = username;
                Account.name = staffname;
                Account.roleid = roleid;
                Account.timeLogin = formattedDateTime;
                Account.roleName = rolename;

                Account.pathImage = st.staff_image;

                ManHinhChinh main = new ManHinhChinh();
                main.Show();
                this.Hide();


            }
            else
            {
                //MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                guna2MessageDialog1.Show(result, "Lỗi");
            }

        }

        private void txt_forgetPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword fg = new ForgotPassword();
            fg.Show();

            this.Hide();
        }
    }
}
