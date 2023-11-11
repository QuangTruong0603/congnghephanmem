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

namespace GUI
{
    public partial class ThemSanPhamOrder : Form
    {

        private int idOrder;

        private BLL_Order bLL_Order = new BLL_Order();
        private BLL_Product bLL_Product = new BLL_Product();


        public ThemSanPhamOrder(int idOrder)
        {
            InitializeComponent();
            this.idOrder = idOrder;

        }

        private void ThemSanPhamOrder_Load(object sender, EventArgs e)
        {

        }

        private void tb_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void tb_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string barcode =tb_barcode.Text.ToString();
            string txtSoluong = tb_soluong.Text.ToString();
            string size  = tb_size.Text.ToString();

            if(barcode == "" || txtSoluong =="" || size == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin sản phẩm cần thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int soluong = int.Parse(txtSoluong);

                if(soluong > 20 || soluong == 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ (Chỉ chấp nhận lớn hơn 0 và nhỏ hơn hoặc bằng 20)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool check = bLL_Product.checkBarcode(barcode);

                    if(check)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DTO_Product pro = bLL_Product.getProductBarcode(barcode);

                        bool add = bLL_Order.addProductOrderDetail(idOrder, pro.product_id, size, soluong, 0);

                        if (add)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Thao tác không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }
    }
}
