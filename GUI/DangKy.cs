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

namespace GUI
{
    public partial class Register : MaterialForm
    {
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

        private void btn_create_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            Login lg = new Login();
            lg.Show();
            Visible = false; ;
        }
    }
}
