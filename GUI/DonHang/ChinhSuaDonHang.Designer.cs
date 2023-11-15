namespace GUI.DonHang
{
    partial class ChinhSuaDonHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_thanhtoan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_trangthaidonhang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tb_phivanchuyen = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_sdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_diachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_tengnuoinhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_eprice = new System.Windows.Forms.Label();
            this.tb_fprice = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.Label();
            this.tb_customer = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.Label();
            this.eprice = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.delivery = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.fprice = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog3 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetail)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(492, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(174, 25);
            this.title.TabIndex = 1;
            this.title.Text = "Mã đơn hàng: 8";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.cb_thanhtoan);
            this.panel1.Controls.Add(this.cb_trangthaidonhang);
            this.panel1.Controls.Add(this.tb_phivanchuyen);
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.tb_diachi);
            this.panel1.Controls.Add(this.tb_tengnuoinhan);
            this.panel1.Controls.Add(this.tb_eprice);
            this.panel1.Controls.Add(this.tb_fprice);
            this.panel1.Controls.Add(this.tb_date);
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
            this.panel1.Location = new System.Drawing.Point(21, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 305);
            this.panel1.TabIndex = 12;
            // 
            // cb_thanhtoan
            // 
            this.cb_thanhtoan.BackColor = System.Drawing.Color.Transparent;
            this.cb_thanhtoan.BorderRadius = 8;
            this.cb_thanhtoan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_thanhtoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_thanhtoan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_thanhtoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_thanhtoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_thanhtoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_thanhtoan.ItemHeight = 30;
            this.cb_thanhtoan.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cb_thanhtoan.Location = new System.Drawing.Point(875, 260);
            this.cb_thanhtoan.Name = "cb_thanhtoan";
            this.cb_thanhtoan.Size = new System.Drawing.Size(203, 36);
            this.cb_thanhtoan.TabIndex = 30;
            // 
            // cb_trangthaidonhang
            // 
            this.cb_trangthaidonhang.BackColor = System.Drawing.Color.Transparent;
            this.cb_trangthaidonhang.BorderRadius = 8;
            this.cb_trangthaidonhang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_trangthaidonhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trangthaidonhang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_trangthaidonhang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_trangthaidonhang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_trangthaidonhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_trangthaidonhang.ItemHeight = 30;
            this.cb_trangthaidonhang.Items.AddRange(new object[] {
            "Chờ lấy hàng",
            "Đang vận chuyển",
            "Đang giao",
            "Đã giao"});
            this.cb_trangthaidonhang.Location = new System.Drawing.Point(875, 214);
            this.cb_trangthaidonhang.Name = "cb_trangthaidonhang";
            this.cb_trangthaidonhang.Size = new System.Drawing.Size(203, 36);
            this.cb_trangthaidonhang.TabIndex = 29;
            // 
            // tb_phivanchuyen
            // 
            this.tb_phivanchuyen.BorderRadius = 8;
            this.tb_phivanchuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_phivanchuyen.DefaultText = "";
            this.tb_phivanchuyen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_phivanchuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_phivanchuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_phivanchuyen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_phivanchuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_phivanchuyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_phivanchuyen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_phivanchuyen.Location = new System.Drawing.Point(870, 106);
            this.tb_phivanchuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_phivanchuyen.Name = "tb_phivanchuyen";
            this.tb_phivanchuyen.PasswordChar = '\0';
            this.tb_phivanchuyen.PlaceholderText = "";
            this.tb_phivanchuyen.SelectedText = "";
            this.tb_phivanchuyen.Size = new System.Drawing.Size(192, 31);
            this.tb_phivanchuyen.TabIndex = 28;
            // 
            // tb_sdt
            // 
            this.tb_sdt.BorderRadius = 8;
            this.tb_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sdt.DefaultText = "";
            this.tb_sdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_sdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_sdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_sdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_sdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_sdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_sdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_sdt.Location = new System.Drawing.Point(209, 206);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.PasswordChar = '\0';
            this.tb_sdt.PlaceholderText = "";
            this.tb_sdt.SelectedText = "";
            this.tb_sdt.Size = new System.Drawing.Size(281, 31);
            this.tb_sdt.TabIndex = 27;
            // 
            // tb_diachi
            // 
            this.tb_diachi.BorderRadius = 8;
            this.tb_diachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_diachi.DefaultText = "";
            this.tb_diachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_diachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_diachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_diachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_diachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_diachi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_diachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_diachi.Location = new System.Drawing.Point(209, 149);
            this.tb_diachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.PasswordChar = '\0';
            this.tb_diachi.PlaceholderText = "";
            this.tb_diachi.SelectedText = "";
            this.tb_diachi.Size = new System.Drawing.Size(281, 31);
            this.tb_diachi.TabIndex = 26;
            // 
            // tb_tengnuoinhan
            // 
            this.tb_tengnuoinhan.BorderRadius = 8;
            this.tb_tengnuoinhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tengnuoinhan.DefaultText = "";
            this.tb_tengnuoinhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_tengnuoinhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_tengnuoinhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_tengnuoinhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_tengnuoinhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_tengnuoinhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_tengnuoinhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_tengnuoinhan.Location = new System.Drawing.Point(209, 102);
            this.tb_tengnuoinhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tengnuoinhan.Name = "tb_tengnuoinhan";
            this.tb_tengnuoinhan.PasswordChar = '\0';
            this.tb_tengnuoinhan.PlaceholderText = "";
            this.tb_tengnuoinhan.SelectedText = "";
            this.tb_tengnuoinhan.Size = new System.Drawing.Size(281, 31);
            this.tb_tengnuoinhan.TabIndex = 25;
            // 
            // tb_eprice
            // 
            this.tb_eprice.AutoSize = true;
            this.tb_eprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_eprice.Location = new System.Drawing.Point(871, 167);
            this.tb_eprice.Name = "tb_eprice";
            this.tb_eprice.Size = new System.Drawing.Size(60, 22);
            this.tb_eprice.TabIndex = 18;
            this.tb_eprice.Text = "label1";
            // 
            // tb_fprice
            // 
            this.tb_fprice.AutoSize = true;
            this.tb_fprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fprice.Location = new System.Drawing.Point(871, 55);
            this.tb_fprice.Name = "tb_fprice";
            this.tb_fprice.Size = new System.Drawing.Size(60, 22);
            this.tb_fprice.TabIndex = 16;
            this.tb_fprice.Text = "label1";
            // 
            // tb_date
            // 
            this.tb_date.AutoSize = true;
            this.tb_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_date.Location = new System.Drawing.Point(205, 260);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(60, 22);
            this.tb_date.TabIndex = 15;
            this.tb_date.Text = "label1";
            // 
            // tb_customer
            // 
            this.tb_customer.AutoSize = true;
            this.tb_customer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customer.Location = new System.Drawing.Point(205, 55);
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
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(24, 105);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(147, 23);
            this.name.TabIndex = 2;
            this.name.Text = "Tên người nhận:";
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataDetail);
            this.panel2.Location = new System.Drawing.Point(21, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 415);
            this.panel2.TabIndex = 14;
            // 
            // dataDetail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataDetail.ColumnHeadersHeight = 28;
            this.dataDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDetail.Location = new System.Drawing.Point(0, 3);
            this.dataDetail.Name = "dataDetail";
            this.dataDetail.RowHeadersVisible = false;
            this.dataDetail.RowHeadersWidth = 51;
            this.dataDetail.RowTemplate.Height = 24;
            this.dataDetail.Size = new System.Drawing.Size(1117, 347);
            this.dataDetail.TabIndex = 13;
            this.dataDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataDetail.ThemeStyle.HeaderStyle.Height = 28;
            this.dataDetail.ThemeStyle.ReadOnly = false;
            this.dataDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDetail.ThemeStyle.RowsStyle.Height = 24;
            this.dataDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataDetail_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmSảnPhẩmToolStripMenuItem,
            this.lưuToolStripMenuItem});
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.tToolStripMenuItem.Text = "Tùy chọn";
            // 
            // thêmSảnPhẩmToolStripMenuItem
            // 
            this.thêmSảnPhẩmToolStripMenuItem.Name = "thêmSảnPhẩmToolStripMenuItem";
            this.thêmSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.thêmSảnPhẩmToolStripMenuItem.Text = "Thêm sản phẩm";
            this.thêmSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.thêmSảnPhẩmToolStripMenuItem_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.lưuToolStripMenuItem.Text = "Lưu";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // guna2MessageDialog2
            // 
            this.guna2MessageDialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog2.Caption = null;
            this.guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog2.Parent = this;
            this.guna2MessageDialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog2.Text = null;
            // 
            // guna2MessageDialog3
            // 
            this.guna2MessageDialog3.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.guna2MessageDialog3.Caption = null;
            this.guna2MessageDialog3.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.guna2MessageDialog3.Parent = this;
            this.guna2MessageDialog3.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog3.Text = null;
            // 
            // ChinhSuaDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 904);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChinhSuaDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa đơn hàng";
            this.Load += new System.EventHandler(this.ChinhSuaDonHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDetail)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tb_eprice;
        private System.Windows.Forms.Label tb_fprice;
        private System.Windows.Forms.Label tb_date;
        private System.Windows.Forms.Label tb_customer;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label sdt;
        private System.Windows.Forms.Label eprice;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label delivery;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label fprice;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2TextBox tb_tengnuoinhan;
        private Guna.UI2.WinForms.Guna2TextBox tb_phivanchuyen;
        private Guna.UI2.WinForms.Guna2TextBox tb_sdt;
        private Guna.UI2.WinForms.Guna2TextBox tb_diachi;
        private Guna.UI2.WinForms.Guna2ComboBox cb_thanhtoan;
        private Guna.UI2.WinForms.Guna2ComboBox cb_trangthaidonhang;
        private Guna.UI2.WinForms.Guna2DataGridView dataDetail;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog3;
    }
}