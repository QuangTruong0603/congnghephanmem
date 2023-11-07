namespace GUI.NguoiDung
{
    partial class ForgotPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_nhapEmail = new MetroSet_UI.Controls.MetroSetLabel();
            this.btn_next = new MetroSet_UI.Controls.MetroSetButton();
            this.txtB_email = new MaterialSkin.Controls.MaterialTextBox();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.txt_nhapEmail);
            this.panel1.Controls.Add(this.txtB_email);
            this.panel1.Location = new System.Drawing.Point(136, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 207);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_nhapEmail
            // 
            this.txt_nhapEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapEmail.IsDerivedStyle = true;
            this.txt_nhapEmail.Location = new System.Drawing.Point(125, 23);
            this.txt_nhapEmail.Name = "txt_nhapEmail";
            this.txt_nhapEmail.Size = new System.Drawing.Size(305, 45);
            this.txt_nhapEmail.Style = MetroSet_UI.Enums.Style.Light;
            this.txt_nhapEmail.StyleManager = null;
            this.txt_nhapEmail.TabIndex = 3;
            this.txt_nhapEmail.Text = "Nhập email tài khoản";
            this.txt_nhapEmail.ThemeAuthor = "Narwin";
            this.txt_nhapEmail.ThemeName = "MetroLite";
            // 
            // btn_next
            // 
            this.btn_next.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_next.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_next.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_next.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_next.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_next.HoverTextColor = System.Drawing.Color.White;
            this.btn_next.IsDerivedStyle = true;
            this.btn_next.Location = new System.Drawing.Point(323, 533);
            this.btn_next.Name = "btn_next";
            this.btn_next.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_next.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_next.NormalTextColor = System.Drawing.Color.White;
            this.btn_next.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_next.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_next.PressTextColor = System.Drawing.Color.White;
            this.btn_next.Size = new System.Drawing.Size(143, 35);
            this.btn_next.Style = MetroSet_UI.Enums.Style.Light;
            this.btn_next.StyleManager = null;
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Tiếp tục";
            this.btn_next.ThemeAuthor = "Narwin";
            this.btn_next.ThemeName = "MetroLite";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // txtB_email
            // 
            this.txtB_email.AnimateReadOnly = false;
            this.txtB_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_email.Depth = 0;
            this.txtB_email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtB_email.Hint = "Nhập email";
            this.txtB_email.LeadingIcon = global::GUI.Properties.Resources.email;
            this.txtB_email.Location = new System.Drawing.Point(106, 100);
            this.txtB_email.MaxLength = 50;
            this.txtB_email.MouseState = MaterialSkin.MouseState.OUT;
            this.txtB_email.Multiline = false;
            this.txtB_email.Name = "txtB_email";
            this.txtB_email.Size = new System.Drawing.Size(313, 50);
            this.txtB_email.TabIndex = 1;
            this.txtB_email.Text = "";
            this.txtB_email.TrailingIcon = null;
            // 
            // img_logo
            // 
            this.img_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_logo.BackColor = System.Drawing.Color.Transparent;
            this.img_logo.Image = global::GUI.Properties.Resources._7_Eleven_Logo;
            this.img_logo.Location = new System.Drawing.Point(242, 80);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(307, 180);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 2;
            this.img_logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(67, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 37);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.panel1);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên mật khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForgotPassword_FormClosing);
            this.Load += new System.EventHandler(this.QuenMatKhau_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroSet_UI.Controls.MetroSetButton btn_next;
        private MaterialSkin.Controls.MaterialTextBox txtB_email;
        private MetroSet_UI.Controls.MetroSetLabel txt_nhapEmail;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}