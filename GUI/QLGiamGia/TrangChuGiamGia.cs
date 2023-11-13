using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI.QLGiamGia
{
    public partial class TrangChuGiamGia : Form
    {
        public TrangChuGiamGia()
        {
            InitializeComponent();
            InitializeTableLayoutPanel();
        }

        private void TrangChuGiamGia_Load(object sender, EventArgs e)
        {

            

        }
        public void getproductById(int id)
        {
           

        } 

        private void tableLayoutPanelSuKien_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void InitializeTableLayoutPanel()
        {

            DAL_Discount2cs dAL_Discount2Cs = new DAL_Discount2cs();
            List<DTO_Discount2> listdiscount = dAL_Discount2Cs.GetDiscount();
            // Thêm 3 cột và 3 hàng

            tableLayoutPanelSuKien.RowCount = listdiscount.Count;

            // Thêm Button và gắn sự kiện Click cho mỗi hàng
            for (int i = 0; i < tableLayoutPanelSuKien.RowCount; i++)
            {
                DAL_Productcs products = new DAL_Productcs();
                List<DTO_product2> productList = products.GetProducts();



                DTO_product2 foundProduct = productList.FirstOrDefault(cust => cust.product_id == listdiscount[i].product_id);

                Button btn_delete = new Button();
          
                btn_delete.Click += RowButtonDelete_Click;
                btn_delete.Paint += CellButtonDelete_Paint;
                btn_delete.Anchor= AnchorStyles.None;

                btn_delete.Tag = listdiscount[i].discount_id;
                tableLayoutPanelSuKien.Controls.Add(btn_delete, 9, i);

                Button btn_update = new Button();

                btn_update.Click += RowButtonUpdate_Click;
                btn_update.Paint += CellButtonUpdate_Paint;
                btn_update.Anchor = AnchorStyles.None;

                btn_update.Tag = listdiscount[i].discount_id;
                tableLayoutPanelSuKien.Controls.Add(btn_update, 8, i);



                Label lb0 = new Label();
                lb0.Text = $" {i + 1}";
                lb0.Anchor = AnchorStyles.None;
                tableLayoutPanelSuKien.Controls.Add(lb0, 0, i);


                tableLayoutPanelSuKien.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));

                Label lb1 = new Label();
                lb1.Text = listdiscount[i].product_id.ToString();
                lb1.Anchor = AnchorStyles.None;
                tableLayoutPanelSuKien.Controls.Add(lb1, 1, i);

                Label lb2 = new Label();
                lb2.Text = foundProduct.product_price.ToString();
                lb2.Anchor = AnchorStyles.None;
                tableLayoutPanelSuKien.Controls.Add(lb2, 2, i);

                Label lb3 = new Label();
                lb3.Text = listdiscount[i].discount_percent.ToString();
                lb3.Anchor = AnchorStyles.None;
                tableLayoutPanelSuKien.Controls.Add(lb3, 3, i);


                Label lb4 = new Label();
                lb4.Text = (foundProduct.product_price*(100-listdiscount[i].discount_percent)/100).ToString();
                lb4.Anchor = AnchorStyles.None;
                tableLayoutPanelSuKien.Controls.Add(lb4, 4, i);

                Label lb5 = new Label();
                lb5.Text = listdiscount[i].start.ToString();
                lb5.Anchor = AnchorStyles.None;
                tableLayoutPanelSuKien.Controls.Add(lb5, 5, i);

                Label lb6 = new Label();
                lb6.Text = listdiscount[i].end.ToString();
                lb6.Anchor = AnchorStyles.None;
                tableLayoutPanelSuKien.Controls.Add(lb6, 6, i);


                Label lb7 = new Label();
                lb7.Text = listdiscount[i].status.ToString();
                lb7.Anchor = AnchorStyles.None;
                tableLayoutPanelSuKien.Controls.Add(lb7, 7, i);



            }
            tableLayoutPaneltitle.RowCount = 1;
            Label labelSTT1 = new Label();
            labelSTT1.Text = "STT";
            labelSTT1.Anchor = AnchorStyles.None;
            Label label2= new Label();
            label2.Text = "Sửa";
            label2.Anchor = AnchorStyles.None;

            Label label3 = new Label();
            label3.Text = "Mã sp KM";
            label3.Anchor = AnchorStyles.None;

            Label label4 = new Label();
            label4.Text = "Giá sp trước";
            label4.Anchor = AnchorStyles.None;

            Label label5 = new Label();
            label5.Text = "% giảm";
            label5.Anchor = AnchorStyles.None;


            Label label6 = new Label();
            label6.Text = "Giá sp sau";
            label6.Anchor = AnchorStyles.None;

            Label label7 = new Label();
            label7.Text = "Ngày bắt đầu";
            label7.Anchor = AnchorStyles.None;

            Label label8 = new Label();
            label8.Text = "Ngày kết thúc";
            label8.Anchor = AnchorStyles.None;


            Label label9 = new Label();
            label9.Text = "Tình trạng";
            label9.Anchor = AnchorStyles.None;

            Label label10 = new Label();
            label10.Text = "Xóa";
            label10.Anchor = AnchorStyles.None;

            tableLayoutPaneltitle.Controls.Add(labelSTT1,0,0);
            tableLayoutPaneltitle.Controls.Add((Label)label2,8,0);
            tableLayoutPaneltitle.Controls.Add((Label)label3, 1, 0);
            tableLayoutPaneltitle.Controls.Add((Label)label4, 2, 0);
            tableLayoutPaneltitle.Controls.Add((Label)label5, 3, 0);
            tableLayoutPaneltitle.Controls.Add((Label)label6, 4, 0);
            tableLayoutPaneltitle.Controls.Add((Label)label7, 5, 0);
            tableLayoutPaneltitle.Controls.Add((Label)label8, 6, 0);
            tableLayoutPaneltitle.Controls.Add((Label)label9, 7, 0);
            tableLayoutPaneltitle.Controls.Add((Label)label10, 9, 0);
        }
        private void CellButtonDelete_Paint(object sender, PaintEventArgs e)
        {
            // Lấy đối tượng Button
            Button button = sender as Button;

            // Lấy đối tượng Graphics để vẽ
            Graphics g = e.Graphics;
            //button.FlatStyle = FlatStyle.Flat;
            int iconSize = 20;
            button.FlatAppearance.BorderSize = 0;
            button.Width = iconSize;
            button.Height = iconSize; 
            //button.FlatStyle = FlatStyle.Flat;

         // Kích thước biểu tượng
            int iconX = (button.Width - iconSize) / 2; // Xác định vị trí X để giữ biểu tượng ở giữa
            int iconY = (button.Height - iconSize) / 2;
            Image icon = Properties.Resources.trash_can; // Thay thế YourIconImage bằng tên hình ảnh trong dự án
            g.DrawImage(icon, iconX, iconY, iconSize, iconSize);
                                                             // Vẽ viền đậm cho từng ô (Button)

        }

        private void RowButtonDelete_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện Click cho hàng tương ứng
            Button clickedButton = (Button)sender;
            long id = (long)clickedButton.Tag;
            

            DeleteConfirm deleteConfirm = new DeleteConfirm(id,this);
            
            deleteConfirm.Show();
           
            
        }


        private void CellButtonUpdate_Paint(object sender, PaintEventArgs e)
        {
            // Lấy đối tượng Button
            Button button = sender as Button;

            // Lấy đối tượng Graphics để vẽ
            Graphics g = e.Graphics;
            //button.FlatStyle = FlatStyle.Flat;
            int iconSize = 20;
            button.FlatAppearance.BorderSize = 0;
            button.Width = iconSize;
            button.Height = iconSize;
            //button.FlatStyle = FlatStyle.Flat;

            // Kích thước biểu tượng
            int iconX = (button.Width - iconSize) / 2; // Xác định vị trí X để giữ biểu tượng ở giữa
            int iconY = (button.Height - iconSize) / 2;
            Image icon = Properties.Resources.pen; // Thay thế YourIconImage bằng tên hình ảnh trong dự án
            g.DrawImage(icon, iconX, iconY, iconSize, iconSize);
            // Vẽ viền đậm cho từng ô (Button)

        }

        private void RowButtonUpdate_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện Click cho hàng tương ứng
            Button clickedButton = (Button)sender;
            long id = (long)clickedButton.Tag;

            Update update = new Update(id,this);
            update.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Hide();
        }
    }
}
