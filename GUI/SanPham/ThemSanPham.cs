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
using DTO;
using System.IO;
using System.Drawing.Imaging;

namespace GUI.SanPham
{
    public partial class ThemSanPham :Form
    {

        private BLL_Product bLL_Product = new BLL_Product();
        private BLL_Category bLL_Category = new BLL_Category(); 
        private BLL_Unit bLL_Unit = new BLL_Unit(); 


        private string filename = "";
        private string filepath = "";

        public ThemSanPham()
        {
            InitializeComponent();
            List<string> listCategory = bLL_Category.getNameCatgory();

            foreach (string category in listCategory)
            {
                cb_loai.Items.Add(category);
            }

            cb_loai.SelectedIndex = 0;


            List<string> listUnit = bLL_Unit.getNameUnit();
            foreach (string unit in listUnit)
            {

                cb_donvitinh.Items.Add(unit);

            }

            cb_donvitinh.SelectedIndex = 0;
        }

        private void ThemSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void ThemSanPham_Load(object sender, EventArgs e)
        {
            

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images FIles (*.jpg; *.png; *.jpeg;) | *.jpg; *.png; *.jpeg;";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filename = dlg.SafeFileName.ToString();
                filepath = dlg.FileName.ToString();

                pictureBox1.Image = new Bitmap(dlg.FileName);

            }
        }

        private void tb_masanpham_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void tb_giasanpham_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DTO_Product p = new DTO_Product();

            p.product_id = -1;
            p.product_name = tb_tensanpham.Text.ToString();
            p.product_barcode = tb_masanpham.Text.ToString();

            string price = tb_giasanpham.Text.ToString();
            int iprice = 0;
            if (price != "")
            {
                iprice = int.Parse(price);
            }
            else
            {
                tb_giasanpham.Text = "0";
            }

            p.product_price = iprice;

            p.product_status = 1;
            p.procduct_image = filename;
            p.unit_id = bLL_Unit.getIdUnitName(cb_donvitinh.Text.ToString());
            p.cate_id = bLL_Category.getIdNameCategory(cb_loai.Text.ToString());
            p.inven_id = 1;

            String res = bLL_Product.checkProduct(p, filename, filepath);

            if (res == "OK")
            {
                bool c = bLL_Product.addNewProduct(p);
                //bool c = true;
                if (c == true)
                {
                    string workingDirectory = Environment.CurrentDirectory;
                    string newpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName.ToString();
                    string newname = bLL_Product.newFilenName(filename);
                    try
                    {

                        String savePath = newpath + "\\GUI\\Resources\\Image Products\\" + newname;
                        pictureBox1.Image.Save(savePath, ImageFormat.Jpeg);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        //  Console.WriteLine(filepath + "\\" + filename);
                        //Console.WriteLine(newpath + "\\GUI\\Resources\\Image Products\\" + newname);

                    }



                    guna2MessageDialog2.Show("Thêm sản phẩm thành công", "Thông báo");

                    this.Close();

                }
                else
                {
                   guna2MessageDialog1.Show("Thêm sản phẩm không thành công", "Lỗi");
                }

            }
            else
            {
                guna2MessageDialog1.Show(res, "Lỗi");
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
