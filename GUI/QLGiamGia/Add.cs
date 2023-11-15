using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLGiamGia
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DAL_Discount2cs dAL_Discount2Cs = new DAL_Discount2cs();


            DAL_Productcs products = new DAL_Productcs();
            List<DTO_product2> productList = products.GetProducts();
            DTO_product2 foundProduct = productList.FirstOrDefault(cust => cust.product_id == long.Parse(textBoxMaSP.Text));

            if (textBoxPercent.Text.Length == 0 || textBoxMaSP.Text.Length == 0 || dateTimePickerStart.Value == null || dateTimePickerEnd.Value == null )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");

            }
            else
            {
                if (dateTimePickerStart.Value.Date > dateTimePickerEnd.Value.Date)
                {
                    MessageBox.Show("Ngày kết thúc không thể trước ngày bắt đầu");
                }
                else if (dateTimePickerEnd.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày kết thúc không thể là ngày trong quá khứ");
                }
                else if(foundProduct == null)
                {
                    MessageBox.Show("Mã sản phẩm không tồn tại");
                }
                else
                {
                    long productid = long.Parse(textBoxMaSP.Text);
                    int percent = int.Parse(textBoxPercent.Text);
                    dAL_Discount2Cs.AddDiscount(productid, percent, dateTimePickerStart.Value, dateTimePickerEnd.Value);
                    TrangChuGiamGia trangChuGiamGia = new TrangChuGiamGia();
                    MessageBox.Show("Thêm thành công");
                    trangChuGiamGia.Show();
                    this.Close();
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChuGiamGia trangChuGiamGia = new TrangChuGiamGia();
            trangChuGiamGia.Show();
        }
    }
}
