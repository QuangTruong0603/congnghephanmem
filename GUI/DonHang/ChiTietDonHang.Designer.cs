namespace GUI
{
    partial class ChiTietDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.title = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.Label();
            this.fprice = new System.Windows.Forms.Label();
            this.delivery = new System.Windows.Forms.Label();
            this.eprice = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.dataDetail = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_thanhtoan = new System.Windows.Forms.Label();
            this.tb_status = new System.Windows.Forms.Label();
            this.tb_eprice = new System.Windows.Forms.Label();
            this.tb_delivery = new System.Windows.Forms.Label();
            this.tb_fprice = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.Label();
            this.tb_customer = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(508, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(174, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Mã đơn hàng: 8";
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.Location = new System.Drawing.Point(21, 54);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(178, 23);
            this.customer.TabIndex = 1;
            this.customer.Text = "Tài khoản đặt hàng:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(24, 105);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(147, 23);
            this.name.TabIndex = 2;
            this.name.Text = "Tên người nhận:";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(24, 157);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(75, 23);
            this.address.TabIndex = 3;
            this.address.Text = "Địa chỉ:";
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt.Location = new System.Drawing.Point(24, 214);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(59, 23);
            this.sdt.TabIndex = 4;
            this.sdt.Text = "SDT: ";
            // 
            // fprice
            // 
            this.fprice.AutoSize = true;
            this.fprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fprice.Location = new System.Drawing.Point(678, 54);
            this.fprice.Name = "fprice";
            this.fprice.Size = new System.Drawing.Size(75, 23);
            this.fprice.TabIndex = 5;
            this.fprice.Text = "Số tiền:";
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery.Location = new System.Drawing.Point(681, 114);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(144, 23);
            this.delivery.TabIndex = 6;
            this.delivery.Text = "Phí vận chuyển:";
            // 
            // eprice
            // 
            this.eprice.AutoSize = true;
            this.eprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eprice.Location = new System.Drawing.Point(681, 166);
            this.eprice.Name = "eprice";
            this.eprice.Size = new System.Drawing.Size(107, 23);
            this.eprice.TabIndex = 7;
            this.eprice.Text = "Thành tiền:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(678, 223);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(190, 23);
            this.status.TabIndex = 8;
            this.status.Text = "Trạng thái đơn hàng: ";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(681, 267);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(112, 23);
            this.payment.TabIndex = 9;
            this.payment.Text = "Thanh toán:";
            // 
            // dataDetail
            // 
            this.dataDetail.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataDetail.ColumnHeadersHeight = 40;
            this.dataDetail.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataDetail.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataDetail.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataDetail.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataDetail.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataDetail.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataDetail.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataDetail.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataDetail.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataDetail.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataDetail.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataDetail.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataDetail.CurrentTheme.Name = null;
            this.dataDetail.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDetail.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataDetail.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataDetail.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataDetail.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataDetail.EnableHeadersVisualStyles = false;
            this.dataDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataDetail.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataDetail.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataDetail.HeaderForeColor = System.Drawing.Color.White;
            this.dataDetail.Location = new System.Drawing.Point(31, 422);
            this.dataDetail.Name = "dataDetail";
            this.dataDetail.ReadOnly = true;
            this.dataDetail.RowHeadersVisible = false;
            this.dataDetail.RowHeadersWidth = 51;
            this.dataDetail.RowTemplate.Height = 40;
            this.dataDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDetail.Size = new System.Drawing.Size(1117, 339);
            this.dataDetail.TabIndex = 10;
            this.dataDetail.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.tb_thanhtoan);
            this.panel1.Controls.Add(this.tb_status);
            this.panel1.Controls.Add(this.tb_eprice);
            this.panel1.Controls.Add(this.tb_delivery);
            this.panel1.Controls.Add(this.tb_fprice);
            this.panel1.Controls.Add(this.tb_date);
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.tb_address);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.tb_customer);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.payment);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.sdt);
            this.panel1.Controls.Add(this.eprice);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.delivery);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.fprice);
            this.panel1.Controls.Add(this.customer);
            this.panel1.Location = new System.Drawing.Point(31, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 305);
            this.panel1.TabIndex = 11;
            // 
            // tb_thanhtoan
            // 
            this.tb_thanhtoan.AutoSize = true;
            this.tb_thanhtoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_thanhtoan.Location = new System.Drawing.Point(795, 267);
            this.tb_thanhtoan.Name = "tb_thanhtoan";
            this.tb_thanhtoan.Size = new System.Drawing.Size(60, 22);
            this.tb_thanhtoan.TabIndex = 20;
            this.tb_thanhtoan.Text = "label1";
            // 
            // tb_status
            // 
            this.tb_status.AutoSize = true;
            this.tb_status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_status.Location = new System.Drawing.Point(874, 223);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(60, 22);
            this.tb_status.TabIndex = 19;
            this.tb_status.Text = "label1";
            // 
            // tb_eprice
            // 
            this.tb_eprice.AutoSize = true;
            this.tb_eprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_eprice.Location = new System.Drawing.Point(795, 166);
            this.tb_eprice.Name = "tb_eprice";
            this.tb_eprice.Size = new System.Drawing.Size(60, 22);
            this.tb_eprice.TabIndex = 18;
            this.tb_eprice.Text = "label1";
            // 
            // tb_delivery
            // 
            this.tb_delivery.AutoSize = true;
            this.tb_delivery.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_delivery.Location = new System.Drawing.Point(837, 114);
            this.tb_delivery.Name = "tb_delivery";
            this.tb_delivery.Size = new System.Drawing.Size(60, 22);
            this.tb_delivery.TabIndex = 17;
            this.tb_delivery.Text = "label1";
            // 
            // tb_fprice
            // 
            this.tb_fprice.AutoSize = true;
            this.tb_fprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fprice.Location = new System.Drawing.Point(782, 54);
            this.tb_fprice.Name = "tb_fprice";
            this.tb_fprice.Size = new System.Drawing.Size(60, 22);
            this.tb_fprice.TabIndex = 16;
            this.tb_fprice.Text = "label1";
            this.tb_fprice.Click += new System.EventHandler(this.tb_fprice_Click);
            // 
            // tb_date
            // 
            this.tb_date.AutoSize = true;
            this.tb_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_date.Location = new System.Drawing.Point(210, 258);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(60, 22);
            this.tb_date.TabIndex = 15;
            this.tb_date.Text = "label1";
            // 
            // tb_sdt
            // 
            this.tb_sdt.AutoSize = true;
            this.tb_sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdt.Location = new System.Drawing.Point(210, 214);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(60, 22);
            this.tb_sdt.TabIndex = 14;
            this.tb_sdt.Text = "label1";
            // 
            // tb_address
            // 
            this.tb_address.AutoSize = true;
            this.tb_address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(210, 157);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(60, 22);
            this.tb_address.TabIndex = 13;
            this.tb_address.Text = "label1";
            // 
            // tb_name
            // 
            this.tb_name.AutoSize = true;
            this.tb_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(210, 105);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(60, 22);
            this.tb_name.TabIndex = 12;
            this.tb_name.Text = "label1";
            // 
            // tb_customer
            // 
            this.tb_customer.AutoSize = true;
            this.tb_customer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customer.Location = new System.Drawing.Point(210, 54);
            this.tb_customer.Name = "tb_customer";
            this.tb_customer.Size = new System.Drawing.Size(60, 22);
            this.tb_customer.TabIndex = 11;
            this.tb_customer.Text = "label1";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(23, 258);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(134, 23);
            this.date.TabIndex = 10;
            this.date.Text = "Ngày tạo đơn: ";
            // 
            // ChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 816);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataDetail);
            this.Controls.Add(this.title);
            this.Name = "ChiTietDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết";
            this.Load += new System.EventHandler(this.ChiTietDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label sdt;
        private System.Windows.Forms.Label fprice;
        private System.Windows.Forms.Label delivery;
        private System.Windows.Forms.Label eprice;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label payment;
        private Bunifu.UI.WinForms.BunifuDataGridView dataDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label tb_thanhtoan;
        private System.Windows.Forms.Label tb_status;
        private System.Windows.Forms.Label tb_eprice;
        private System.Windows.Forms.Label tb_delivery;
        private System.Windows.Forms.Label tb_fprice;
        private System.Windows.Forms.Label tb_date;
        private System.Windows.Forms.Label tb_sdt;
        private System.Windows.Forms.Label tb_address;
        private System.Windows.Forms.Label tb_name;
        private System.Windows.Forms.Label tb_customer;
    }
}