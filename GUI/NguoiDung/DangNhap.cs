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

namespace GUI
{
    public partial class Login : MaterialForm
    {

        private BLL_Login_Staff bLL_Login_Staff = new BLL_Login_Staff();
     
        public Login()
        {
            InitializeComponent();
            var skinManage = MaterialSkin.MaterialSkinManager.Instance;
            skinManage.AddFormToManage(this);
            skinManage.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManage.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green700, MaterialSkin.Primary.Green800,MaterialSkin.Primary.Green300,Accent.LightGreen700,TextShade.WHITE);
             

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
                txt_dangnhap.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 16);
                txt_matkhau.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 16);
               forgotPassword.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 13);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ch_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(ch_showpass.Checked == true)
            {
                txt_password.Password = false;
            }
            else
            {
                txt_password.Password = true;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
         Environment.Exit(0);
          Application.Exit();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            Visible = false;
        }    


        private void btn_dangnhap_Click_1(object sender, EventArgs e)
        {
           
            String username = txt_username.Text.ToString();
            String password = txt_password.Text.ToString();

            String result = bLL_Login_Staff.checkLogin(username, password);

            if(result == "Thành công")
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
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {

            ForgotPassword fg = new ForgotPassword();
            fg.Show();

            this.Hide();
        }

        private void forgotPassword_MouseHover(object sender, EventArgs e)
        {
            forgotPassword.ForeColor = Color.Red;
        }

        private void forgotPassword_MouseLeave(object sender, EventArgs e)
        {
            forgotPassword.ForeColor = Color.Black;
        }
    }
}
