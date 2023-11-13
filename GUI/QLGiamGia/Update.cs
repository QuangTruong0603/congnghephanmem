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
    public partial class Update : Form
    {
        private long id;
        private TrangChuGiamGia tc;

        public Update(long id, TrangChuGiamGia tc)
        {
            InitializeComponent();
            this.id = id;
            this.tc = tc;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            DAL_Discount2cs dAL_Discount2Cs = new DAL_Discount2cs();
            List<DTO_Discount2> dTO_Discount2s = dAL_Discount2Cs.GetDiscount();


            DTO_Discount2 founddiscount = dTO_Discount2s.FirstOrDefault(cust => cust.discount_id == id);

            if (founddiscount != null)
            {
                textBoxMaSP.Text = founddiscount.product_id.ToString();
                textBoxpercent.Text = founddiscount.discount_percent.ToString();
                dateTimePickerStart.Value = founddiscount.start;
                dateTimePickerEnd.Value = founddiscount.end;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DAL_Discount2cs dAL_Discount2Cs = new DAL_Discount2cs();


            DAL_Productcs products = new DAL_Productcs();
            List<DTO_product2> productList = products.GetProducts();
            DTO_product2 foundProduct = productList.FirstOrDefault(cust => cust.product_id == long.Parse(textBoxMaSP.Text));

            if (textBoxpercent.Text.Length == 0 || textBoxMaSP.Text.Length == 0 || dateTimePickerStart.Value == null || dateTimePickerEnd.Value == null)
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
                else if (foundProduct == null)
                {
                    MessageBox.Show("Mã sản phẩm không tồn tại");
                }
                else
                {
                    long productid = long.Parse(textBoxMaSP.Text);
                    int percent = int.Parse(textBoxpercent.Text);
                    dAL_Discount2Cs.UpdateDiscount(id, percent, dateTimePickerStart.Value, dateTimePickerEnd.Value,productid);
                    TrangChuGiamGia trangChuGiamGia = new TrangChuGiamGia();
                    MessageBox.Show("Cập nhật thành công");
                    trangChuGiamGia.Show();
                    tc.Hide();
                    this.Close();
                }

            }
        }
    }
}
