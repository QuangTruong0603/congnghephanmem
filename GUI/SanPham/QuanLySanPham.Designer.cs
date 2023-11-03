namespace GUI.SanPham
{
    partial class QuanLySanPham
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textb_search = new System.Windows.Forms.TextBox();
            this.databasev1DataSet = new GUI.databasev1DataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new GUI.databasev1DataSetTableAdapters.StaffTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dataSanPham = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.img_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.databasev1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textb_search
            // 
            this.textb_search.Location = new System.Drawing.Point(748, 32);
            this.textb_search.Name = "textb_search";
            this.textb_search.Size = new System.Drawing.Size(334, 22);
            this.textb_search.TabIndex = 7;
            this.textb_search.Enter += new System.EventHandler(this.textb_search_Enter);
            this.textb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textb_search_KeyDown);
            this.textb_search.Leave += new System.EventHandler(this.textb_search_Leave);
            // 
            // databasev1DataSet
            // 
            this.databasev1DataSet.DataSetName = "databasev1DataSet";
            this.databasev1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.databasev1DataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.dataSanPham);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.textb_search);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Location = new System.Drawing.Point(24, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 522);
            this.panel1.TabIndex = 11;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_refresh.Image = global::GUI.Properties.Resources.refresh_page_option;
            this.btn_refresh.Location = new System.Drawing.Point(532, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(112, 60);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dataSanPham
            // 
            this.dataSanPham.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataSanPham.ColumnHeadersHeight = 40;
            this.dataSanPham.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataSanPham.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataSanPham.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataSanPham.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataSanPham.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataSanPham.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataSanPham.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataSanPham.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataSanPham.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataSanPham.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataSanPham.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataSanPham.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataSanPham.CurrentTheme.Name = null;
            this.dataSanPham.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataSanPham.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataSanPham.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataSanPham.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataSanPham.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataSanPham.EnableHeadersVisualStyles = false;
            this.dataSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataSanPham.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataSanPham.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataSanPham.HeaderForeColor = System.Drawing.Color.White;
            this.dataSanPham.Location = new System.Drawing.Point(-35, 125);
            this.dataSanPham.Name = "dataSanPham";
            this.dataSanPham.ReadOnly = true;
            this.dataSanPham.RowHeadersVisible = false;
            this.dataSanPham.RowHeadersWidth = 51;
            this.dataSanPham.RowTemplate.Height = 40;
            this.dataSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSanPham.Size = new System.Drawing.Size(1379, 394);
            this.dataSanPham.TabIndex = 11;
            this.dataSanPham.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add.Image = global::GUI.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(46, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 60);
            this.btn_add.TabIndex = 8;
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_edit.Image = global::GUI.Properties.Resources.editing;
            this.btn_edit.Location = new System.Drawing.Point(371, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(112, 60);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Image = global::GUI.Properties.Resources.bin;
            this.btn_delete.Location = new System.Drawing.Point(208, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 60);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // img_logo
            // 
            this.img_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_logo.Image = global::GUI.Properties.Resources._7_Eleven_Logo;
            this.img_logo.Location = new System.Drawing.Point(1118, 82);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(276, 106);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 3;
            this.img_logo.TabStop = false;
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_logo);
            this.Name = "QuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLySanPham_FormClosing);
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databasev1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.TextBox textb_search;
        private databasev1DataSet databasev1DataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private databasev1DataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataSanPham;
        private System.Windows.Forms.Button btn_refresh;
    }
}