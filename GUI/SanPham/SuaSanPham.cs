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

namespace GUI.SanPham
{
    public partial class SuaSanPham : Form
    {

        private BLL_Product bLL_Product = new BLL_Product();
        private BLL_Category bLL_Category = new BLL_Category();
        private BLL_Unit bLL_Unit = new BLL_Unit();
        private DTO_Product product;

        public SuaSanPham(DTO_Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void SuaSanPham_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#66C2AD");


            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.FlatAppearance.BorderSize = 0;


            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.FlatAppearance.BorderSize = 0;


            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_save, "Lưu");


            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_cancel, "Hủy");


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
            tb_tensanpham.Text = product.product_name.ToString ();
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

        private void tb_masanpham_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void tb_giasanpham_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
