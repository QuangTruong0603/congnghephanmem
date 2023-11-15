using DTO;
using GUI.SanPham;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace GUI
{
    public partial class ManHinhChinh : Form
    {
    
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            timer1.Start();

            username.Text = Account.username;
            rolename.Text = Account.roleName;

           string workingDirectory = Environment.CurrentDirectory;
           string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName.ToString();

           Image img = Image.FromFile(path + "\\GUI\\Resources\\Avatar\\" + Account.pathImage);
           avatar.Image = img;
        }

        private void ManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void avatar_Click(object sender, EventArgs e)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Thông tin nhân viên", (s, args) => { ViewDetail(); });
            cm.MenuItems.Add("Đăng xuất", (s, args) => { logout();});

            avatar.ContextMenu = cm;
        }

        public  void ViewDetail()
        {
            MessageBox.Show("detail", "abc");
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void logout()
        {
            Account.username = null;
            Account.name = null;
            Account.roleid = -1;
            Account.timeLogin = null;
            Account.roleName = null;

            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
           logout();
        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {
            QuanLySanPham qlsp = new QuanLySanPham();
            qlsp.ShowDialog();
           
        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            QuanLyGiaoHang quanLyGiaoHang = new QuanLyGiaoHang();
            quanLyGiaoHang.ShowDialog();
        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon qlhd = new QuanLyHoaDon();
            qlhd.ShowDialog();
        }
    }
}
