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

namespace GUI
{
    public partial class ChiTietDonHang : Form
    {


        private int idOrder;

        private BLL_Order bLL_Order = new BLL_Order();

        public ChiTietDonHang(int idOrder)
        {
            InitializeComponent();
            this.idOrder = idOrder;


            dataDetail.AllowUserToAddRows = false;

            dataDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataDetail.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void ChiTietDonHang_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic = bLL_Order.getOrderById(idOrder);

            int fprice = 0;
            int lprice = 0;

            foreach (KeyValuePair<string, string> item in dic)
            {

               

                if (item.Key.Equals("madonhang"))
                {
                    title.Text = "Mã đơn hàng: " + item.Value;

                }


                if (item.Key.Equals("tennguoinhan"))
                {
                    tb_name.Text =  item.Value;

                }

                if (item.Key.Equals("diachi"))
                {
                    tb_address.Text = item.Value;
                }

                if (item.Key.Equals("sdt"))
                {
                    tb_sdt.Text = item.Value;
                }

                if (item.Key.Equals("sotien"))
                {
                    tb_eprice.Text = item.Value +" VND";

                    lprice = int.Parse(item.Value.ToString());
                }


                if (item.Key.Equals("trangthai"))
                {
                    tb_status.Text = item.Value;
                }

                if (item.Key.Equals("thanhtoan"))
                {
                     tb_thanhtoan.Text = item.Value;
                }

                if (item.Key.Equals("tkdh"))
                {
                    tb_customer.Text = item.Value;
                }

                if (item.Key.Equals("sdttkdh"))
                {
                    tb_customer.Text = tb_customer.Text + "-" + item.Value;
                }

                if (item.Key.Equals("ngaytaodon"))
                {
                    tb_date.Text = item.Value;
                }

                if (item.Key.Equals("sotienbandau"))
                {
                    tb_fprice.Text = item.Value +" VND";
                    fprice = int.Parse(item.Value.ToString());
                }

           

            }

            int delivery = lprice - fprice;

            tb_delivery.Text = delivery.ToString() + " VND";


            dataDetail.DataSource = bLL_Order.getOrderDetailById(idOrder);

        }

        private void tb_fprice_Click(object sender, EventArgs e)
        {

        }
    }
}
