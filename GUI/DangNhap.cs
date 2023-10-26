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

namespace GUI
{
    public partial class Login : MaterialForm
    {
        
     
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
            //txt_dangnhap.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 16);
            //txt_matkhau.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 16);
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
            string username = txt_username.Text.ToString();
            string password = txt_password.Text;
            BLL_Login_Staff bLL_Login_Staff = new BLL_Login_Staff();
            //if(bLL_Login_Staff.checkLogin(username, password))
            //{
            //    MessageBox.Show("Đăng nhập thành công");
            //}
            //else
            //{
            //    MessageBox.Show("Đăng nhập thất bại");
            //}
            MessageBox.Show(username.Equals("cho").ToString());
            MessageBox.Show(password.Length.ToString()); 
            MessageBox.Show(bLL_Login_Staff.checkLogin(username, password));
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
