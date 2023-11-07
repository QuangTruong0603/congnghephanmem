namespace GUI
{
    partial class Register
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
            this.ch_showpass = new MaterialSkin.Controls.MaterialCheckbox();
            this.txt_confirmpassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_username = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_email = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_tittleConfirm = new System.Windows.Forms.Label();
            this.txt_titleMatkhau = new System.Windows.Forms.Label();
            this.txt_titleTaiKhoan = new System.Windows.Forms.Label();
            this.txt_titleEmail = new System.Windows.Forms.Label();
            this.btn_create = new MetroSet_UI.Controls.MetroSetButton();
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
            this.panel1.Controls.Add(this.ch_showpass);
            this.panel1.Controls.Add(this.txt_confirmpassword);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_tittleConfirm);
            this.panel1.Controls.Add(this.txt_titleMatkhau);
            this.panel1.Controls.Add(this.txt_titleTaiKhoan);
            this.panel1.Controls.Add(this.txt_titleEmail);
            this.panel1.Location = new System.Drawing.Point(199, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 410);
            this.panel1.TabIndex = 3;
            // 
            // ch_showpass
            // 
            this.ch_showpass.AutoSize = true;
            this.ch_showpass.Depth = 0;
            this.ch_showpass.Location = new System.Drawing.Point(262, 353);
            this.ch_showpass.Margin = new System.Windows.Forms.Padding(0);
            this.ch_showpass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ch_showpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.ch_showpass.Name = "ch_showpass";
            this.ch_showpass.ReadOnly = false;
            this.ch_showpass.Ripple = true;
            this.ch_showpass.Size = new System.Drawing.Size(138, 37);
            this.ch_showpass.TabIndex = 8;
            this.ch_showpass.Text = "Hiện mật khẩu";
            this.ch_showpass.UseVisualStyleBackColor = true;
            this.ch_showpass.CheckedChanged += new System.EventHandler(this.ch_showpass_CheckedChanged);
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.AnimateReadOnly = false;
            this.txt_confirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirmpassword.Depth = 0;
            this.txt_confirmpassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_confirmpassword.Hint = "Xác nhận lại mật khẩu";
            this.txt_confirmpassword.LeadingIcon = global::GUI.Properties.Resources.padlock;
            this.txt_confirmpassword.Location = new System.Drawing.Point(262, 291);
            this.txt_confirmpassword.MaxLength = 50;
            this.txt_confirmpassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_confirmpassword.Multiline = false;
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.Password = true;
            this.txt_confirmpassword.Size = new System.Drawing.Size(423, 50);
            this.txt_confirmpassword.TabIndex = 7;
            this.txt_confirmpassword.Text = "";
            this.txt_confirmpassword.TrailingIcon = null;
            // 
            // txt_password
            // 
            this.txt_password.AnimateReadOnly = false;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.Hint = "Nhập mật khẩu";
            this.txt_password.LeadingIcon = global::GUI.Properties.Resources.padlock;
            this.txt_password.Location = new System.Drawing.Point(262, 209);
            this.txt_password.MaxLength = 50;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Password = true;
            this.txt_password.Size = new System.Drawing.Size(423, 50);
            this.txt_password.TabIndex = 6;
            this.txt_password.Text = "";
            this.txt_password.TrailingIcon = null;
            // 
            // txt_username
            // 
            this.txt_username.AnimateReadOnly = false;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Depth = 0;
            this.txt_username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_username.Hint = "Nhập tên tài khoản";
            this.txt_username.LeadingIcon = global::GUI.Properties.Resources.user;
            this.txt_username.Location = new System.Drawing.Point(262, 134);
            this.txt_username.MaxLength = 50;
            this.txt_username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(423, 50);
            this.txt_username.TabIndex = 5;
            this.txt_username.Text = "";
            this.txt_username.TrailingIcon = null;
            // 
            // txt_email
            // 
            this.txt_email.AnimateReadOnly = false;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Depth = 0;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_email.Hint = "Nhập email";
            this.txt_email.LeadingIcon = global::GUI.Properties.Resources.email;
            this.txt_email.Location = new System.Drawing.Point(262, 48);
            this.txt_email.MaxLength = 50;
            this.txt_email.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(423, 50);
            this.txt_email.TabIndex = 4;
            this.txt_email.Text = "";
            this.txt_email.TrailingIcon = null;
            // 
            // txt_tittleConfirm
            // 
            this.txt_tittleConfirm.AutoSize = true;
            this.txt_tittleConfirm.Location = new System.Drawing.Point(10, 302);
            this.txt_tittleConfirm.Name = "txt_tittleConfirm";
            this.txt_tittleConfirm.Size = new System.Drawing.Size(114, 16);
            this.txt_tittleConfirm.TabIndex = 3;
            this.txt_tittleConfirm.Text = "Nhập lại mật khẩu";
            // 
            // txt_titleMatkhau
            // 
            this.txt_titleMatkhau.AutoSize = true;
            this.txt_titleMatkhau.Location = new System.Drawing.Point(10, 225);
            this.txt_titleMatkhau.Name = "txt_titleMatkhau";
            this.txt_titleMatkhau.Size = new System.Drawing.Size(61, 16);
            this.txt_titleMatkhau.TabIndex = 2;
            this.txt_titleMatkhau.Text = "Mật khẩu";
            // 
            // txt_titleTaiKhoan
            // 
            this.txt_titleTaiKhoan.AutoSize = true;
            this.txt_titleTaiKhoan.Location = new System.Drawing.Point(10, 147);
            this.txt_titleTaiKhoan.Name = "txt_titleTaiKhoan";
            this.txt_titleTaiKhoan.Size = new System.Drawing.Size(88, 16);
            this.txt_titleTaiKhoan.TabIndex = 1;
            this.txt_titleTaiKhoan.Text = "Tên tài khoản";
            // 
            // txt_titleEmail
            // 
            this.txt_titleEmail.AutoSize = true;
            this.txt_titleEmail.Location = new System.Drawing.Point(10, 61);
            this.txt_titleEmail.Name = "txt_titleEmail";
            this.txt_titleEmail.Size = new System.Drawing.Size(41, 16);
            this.txt_titleEmail.TabIndex = 0;
            this.txt_titleEmail.Text = "Email";
            // 
            // btn_create
            // 
            this.btn_create.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_create.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_create.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_create.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_create.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_create.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_create.HoverTextColor = System.Drawing.Color.White;
            this.btn_create.IsDerivedStyle = true;
            this.btn_create.Location = new System.Drawing.Point(465, 725);
            this.btn_create.Name = "btn_create";
            this.btn_create.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_create.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_create.NormalTextColor = System.Drawing.Color.White;
            this.btn_create.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_create.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_create.PressTextColor = System.Drawing.Color.White;
            this.btn_create.Size = new System.Drawing.Size(160, 53);
            this.btn_create.Style = MetroSet_UI.Enums.Style.Light;
            this.btn_create.StyleManager = null;
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Tạo tài khoản";
            this.btn_create.ThemeAuthor = "Narwin";
            this.btn_create.ThemeName = "MetroLite";
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // img_logo
            // 
            this.img_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_logo.BackColor = System.Drawing.Color.Transparent;
            this.img_logo.Image = global::GUI.Properties.Resources._7_Eleven_Logo;
            this.img_logo.Location = new System.Drawing.Point(396, 104);
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
            this.pictureBox1.Location = new System.Drawing.Point(67, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 36);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 800);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_logo);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_tittleConfirm;
        private System.Windows.Forms.Label txt_titleMatkhau;
        private System.Windows.Forms.Label txt_titleTaiKhoan;
        private System.Windows.Forms.Label txt_titleEmail;
        private MaterialSkin.Controls.MaterialTextBox txt_username;
        private MaterialSkin.Controls.MaterialTextBox txt_email;
        private MaterialSkin.Controls.MaterialTextBox txt_confirmpassword;
        private MaterialSkin.Controls.MaterialTextBox txt_password;
        private MetroSet_UI.Controls.MetroSetButton btn_create;
        private MaterialSkin.Controls.MaterialCheckbox ch_showpass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}