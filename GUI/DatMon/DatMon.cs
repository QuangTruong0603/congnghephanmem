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
using DAL;
using System.Security.AccessControl;

namespace GUI.DatMon
{
    public partial class DatMon : Form
    {
        private int tongcong = 0;
        Color maunen = Color.FromArgb(250, 152, 125);
        public DatMon()
        {
            InitializeComponent();
        }

        private void DatMon_Load(object sender, EventArgs e)
        {
            enabledButton();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            flowLayoutPanelItem.Controls.Clear();
            button1.BackColor = Color.Red;
            btn_All.BackColor = maunen;
            btn_coffee.BackColor = maunen;
            btn_nuocuong.BackColor = maunen;


            List<DTO_product2> dTO_Products = new List<DTO_product2>();
            DAL_Productcs dAL_Product = new DAL_Productcs();

            dTO_Products = dAL_Product.GetProducts();

            if (dTO_Products != null && dTO_Products.Count > 0)
            {

                product_item[] itemProducts = new product_item[dTO_Products.Count];
                for (int i = 0; i < dTO_Products.Count; i++)
                {
                    if (dTO_Products[i].cate_id == 2)
                    {
                        itemProducts[i] = new product_item();
                        itemProducts[i].ProcName = dTO_Products[i].product_name;
                        itemProducts[i].ProcPrice = dTO_Products[i].product_price.ToString();
                        itemProducts[i].procImage = Image.FromFile("D:\\coca.jpg");
                        itemProducts[i].Margin = new Padding(7);
                        itemProducts[i].ItemClicked += ItemProduct_ItemClicked;
                        flowLayoutPanelItem.Controls.Add(itemProducts[i]);
                    }
                    
                }

            }
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            
            flowLayoutPanelItem.Controls.Clear();
           
            btn_All.BackColor = Color.Red;
            btn_coffee.BackColor = maunen;
            btn_nuocuong.BackColor = maunen;
            button1.BackColor = maunen;

            List<DTO_product2> dTO_Products = new List<DTO_product2>();
            DAL_Productcs dAL_Product = new DAL_Productcs();
       
            dTO_Products = dAL_Product.GetProducts();
            
            if (dTO_Products != null && dTO_Products.Count > 0)
            {
 
                product_item[] itemProducts = new product_item[dTO_Products.Count];
                for (int i = 0; i < dTO_Products.Count; i++)
                {
                    if (dTO_Products[i].cate_id != 0)
                    {
                        itemProducts[i] = new product_item();
                        itemProducts[i].ProcName = dTO_Products[i].product_name;
                        itemProducts[i].ProcPrice = dTO_Products[i].product_price.ToString();
                        itemProducts[i].procImage = Image.FromFile("D:\\coca.jpg");
                        itemProducts[i].Margin = new Padding(7);
                        itemProducts[i].ItemClicked += ItemProduct_ItemClicked;
                        flowLayoutPanelItem.Controls.Add(itemProducts[i]);
                    }
                    
                }
                
            }
        }
        private List<ThanhToanItem> item_Thanhtoans = new List<ThanhToanItem>();
        private List<product_item> item_selected = new List<product_item>();
        private void ItemProduct_ItemClicked(object sender, EventArgs e)
        {
            // Xử lý sự kiện click của một ItemProduct
            product_item itemProduct = sender as product_item;
            if (itemProduct != null)
            {
                
                // Thêm ItemProduct đã chọn vào danh sách selectedItems
                if (!item_selected.Contains(itemProduct))
                {
                    // Nếu mục chưa được chọn, thêm vào danh sách
                    item_selected.Add(itemProduct);

                    ThanhToanItem thanhtoan = new ThanhToanItem();
                    thanhtoan.procName = itemProduct.ProcName;
                    thanhtoan.procDongia = itemProduct.ProcPrice;
                    thanhtoan.ItemDeleteClicked += ItemThanhToan_DeleteClicked;
                    thanhtoan.ValueChanged += ThanhToanItem_ValueChanged;
                    thanhtoan.Margin = new Padding(5);
                    
                    item_Thanhtoans.Add(thanhtoan);
                    enabledButton();
                    flowLayoutPanelThanhToan.Controls.Add(thanhtoan);
                }
            
            }
          

        }
        private void enabledButton()
        {
            if(item_Thanhtoans.Count == 0)
            {
                btnTichDiem.Enabled = false;
                btnThanhToan.Enabled = false;
            }
            else
            {
                btnThanhToan.Enabled= true;
                btnTichDiem.Enabled = true;
            }
        }
        private void ItemThanhToan_DeleteClicked(object sender, EventArgs e)
        {
            ThanhToanItem item = sender as ThanhToanItem;
            if(item != null)
            {
                item_Thanhtoans.Remove(item);
                enabledButton();
                updateTong();
                // Loại bỏ ThanhToanItem khỏi flowLayoutPanelThanhToan
                flowLayoutPanelThanhToan.Controls.Remove(item);
            }
        }

        private void ThanhToanItem_ValueChanged(object sender, EventArgs e)
        {

            updateTong();
       
        }
        private void updateTong()
        {
            int tong = 0;
            // Tính toán tổng từ các ThanhToanItem và cập nhật labelToong.Text

            foreach (ThanhToanItem thanhToanItem in item_Thanhtoans)
            {

                tong = int.Parse(thanhToanItem.procDongia) * thanhToanItem.procSoluong + tong;



            }
            tongcong = tong;

            Tongtien.Text = tong.ToString();
        }

        private void btnTichDiem_Click(object sender, EventArgs e)
        {
            DangNhapTichDiem td = new DangNhapTichDiem(tongcong);
           
            
            td.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            thanhtoan tt = new thanhtoan(tongcong);
            tt.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            btn_All.BackColor = maunen;
            btn_coffee.BackColor = maunen;
            btn_nuocuong.BackColor = maunen;
            button1.BackColor = maunen;
            string search = textBoxSearch.Text; 

            flowLayoutPanelItem.Controls.Clear();
            

            List<DTO_product2> dTO_Products = new List<DTO_product2>();
            DAL_Productcs dAL_Product = new DAL_Productcs();

            dTO_Products = dAL_Product.GetProducts();

            if (dTO_Products != null && dTO_Products.Count > 0)
            {

                product_item[] itemProducts = new product_item[dTO_Products.Count];
                for (int i = 0; i < dTO_Products.Count; i++)
                {
                    if (dTO_Products[i].product_name.ToLower().Contains(search.ToLower()))
                    {
                        itemProducts[i] = new product_item();
                        itemProducts[i].ProcName = dTO_Products[i].product_name;
                        itemProducts[i].ProcPrice = dTO_Products[i].product_price.ToString();
                        itemProducts[i].procImage = Image.FromFile("D:\\coca.jpg");
                        itemProducts[i].Margin = new Padding(7);
                        itemProducts[i].ItemClicked += ItemProduct_ItemClicked;
                        flowLayoutPanelItem.Controls.Add(itemProducts[i]);
                    }

                }

            }
        }

        private void btn_nuocuong_Click(object sender, EventArgs e)
        {
            flowLayoutPanelItem.Controls.Clear();

            btn_All.BackColor = maunen;
            btn_coffee.BackColor = maunen;
            btn_nuocuong.BackColor = Color.Red;
            button1.BackColor = maunen;

            List<DTO_product2> dTO_Products = new List<DTO_product2>();
            DAL_Productcs dAL_Product = new DAL_Productcs();

            dTO_Products = dAL_Product.GetProducts();

            if (dTO_Products != null && dTO_Products.Count > 0)
            {

                product_item[] itemProducts = new product_item[dTO_Products.Count];
                for (int i = 0; i < dTO_Products.Count; i++)
                {
                    if (dTO_Products[i].cate_id == 1)
                    {
                        itemProducts[i] = new product_item();
                        itemProducts[i].ProcName = dTO_Products[i].product_name;
                        itemProducts[i].ProcPrice = dTO_Products[i].product_price.ToString();
                        itemProducts[i].procImage = Image.FromFile("D:\\coca.jpg");
                        itemProducts[i].Margin = new Padding(7);
                        itemProducts[i].ItemClicked += ItemProduct_ItemClicked;
                        flowLayoutPanelItem.Controls.Add(itemProducts[i]);
                    }

                }

            }
        }

        private void btn_coffee_Click(object sender, EventArgs e)
        {
            flowLayoutPanelItem.Controls.Clear();

            btn_All.BackColor = maunen;
            btn_coffee.BackColor = Color.Red;
            btn_nuocuong.BackColor = maunen;
            button1.BackColor = maunen;

            List<DTO_product2> dTO_Products = new List<DTO_product2>();
            DAL_Productcs dAL_Product = new DAL_Productcs();

            dTO_Products = dAL_Product.GetProducts();

            if (dTO_Products != null && dTO_Products.Count > 0)
            {

                product_item[] itemProducts = new product_item[dTO_Products.Count];
                for (int i = 0; i < dTO_Products.Count; i++)
                {
                    if (dTO_Products[i].cate_id == 3)
                    {
                        itemProducts[i] = new product_item();
                        itemProducts[i].ProcName = dTO_Products[i].product_name;
                        itemProducts[i].ProcPrice = dTO_Products[i].product_price.ToString();
                        itemProducts[i].procImage = Image.FromFile("D:\\coca.jpg");
                        itemProducts[i].Margin = new Padding(7);
                        itemProducts[i].ItemClicked += ItemProduct_ItemClicked;
                        flowLayoutPanelItem.Controls.Add(itemProducts[i]);
                    }

                }

            }
        }
    }
}
