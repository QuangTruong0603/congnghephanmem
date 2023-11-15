using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.IO;
using System.Reflection;
using System.Drawing.Imaging;

namespace GUI.SanPham
{
    public partial class SuaSanPham : Form
    {

        private BLL_Product bLL_Product = new BLL_Product();
        private BLL_Category bLL_Category = new BLL_Category();
        private BLL_Unit bLL_Unit = new BLL_Unit();
        private DTO_Product product;

        private string filename = "";
        private string filepath = "";

        public SuaSanPham(DTO_Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void SuaSanPham_Load(object sender, EventArgs e)
        {
            List<string> listCategory = bLL_Category.getNameCatgory();

            foreach (string category in listCategory)
            {
                cb_loai.Items.Add(category);
            }



            List<string> listUnit = bLL_Unit.getNameUnit();
            foreach (string unit in listUnit)
            {

                cb_donvitinh.Items.Add(unit);

            }



            tb_masanpham.Text = product.product_barcode.ToString();
            tb_tensanpham.Text = product.product_name.ToString();
            tb_giasanpham.Text = product.product_price.ToString();



            string imgName = product.procduct_image.ToString();


            string workingDirectory = Environment.CurrentDirectory;
            string newpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName.ToString();
            string folder = "\\GUI\\Resources\\Image Products\\";

            string path = newpath + folder + imgName;

            pictureBox1.Image = new Bitmap(path);


            DTO_Category dTO_Category = bLL_Category.getCategoryById(product.cate_id);
            DTO_Unit dTO_Unit = bLL_Unit.getUnitById(product.unit_id);




            cb_donvitinh.SelectedIndex = cb_donvitinh.FindStringExact(dTO_Unit.unit_name);
            cb_loai.SelectedIndex = cb_loai.FindStringExact(dTO_Category.cate_name);
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {

        }

        private void tb_giasanpham_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_masanpham_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void tb_masanpham_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void tb_giasanpham_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }


        public void refreshData()
        {
            var frm = (QuanLySanPham)this.Owner;
            if (frm != null)
                frm.btn_refresh.PerformClick();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean saveProductUpdate(DTO_Product product)
        {
            return bLL_Product.updateProduct(product);
        }

        private void btn_upload_Click_1(object sender, EventArgs e)
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

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            DTO_Product updateProduct = new DTO_Product();


            updateProduct.product_id = product.product_id;
            updateProduct.inven_id = product.inven_id;


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

            updateProduct.product_price = iprice;

            updateProduct.product_status = product.product_status;

            updateProduct.product_name = tb_tensanpham.Text.ToString();
            updateProduct.product_barcode = tb_masanpham.Text.ToString();

            updateProduct.unit_id = bLL_Unit.getIdUnitName(cb_donvitinh.Text.ToString());
            updateProduct.cate_id = bLL_Category.getIdNameCategory(cb_loai.Text.ToString());


            if (filename == "" && filepath == "")
            {
                updateProduct.procduct_image = product.procduct_image;

            }
            else
            {
                string newNameImage = bLL_Product.newFilenName(filename);
                updateProduct.procduct_image = newNameImage;
            }


            string checkProduct = "";


            if (product.product_barcode == updateProduct.product_barcode)
            {
                checkProduct = bLL_Product.checkProductNoBarcode(updateProduct, filename, filepath);
            }
            else
            {

                checkProduct = bLL_Product.checkProduct(updateProduct, filename, filepath);
            }



            if (checkProduct == "OK")
            {
                bool c = bLL_Product.updateProduct(updateProduct);

                if (c == true)
                {

                    if (filename != "" && filepath != "")
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

                        }


                        guna2MessageDialog2.Show("Chỉnh sửa sản phẩm thành công", "Thông báo");
                        refreshData();
                        this.Close();


                    }
                    else
                    {
                       guna2MessageDialog2.Show("Chỉnh sửa sản phẩm thành công", "Thông báo");
                        refreshData();
                        this.Close();
                    }

                }
                else
                {
                   guna2MessageDialog1.Show("Chỉnh sửa thông tin thất bại", "Lỗi");
                }
            }
            else
            {
               guna2MessageDialog1.Show(checkProduct, "Lỗi");
            }

        }
    }
}
