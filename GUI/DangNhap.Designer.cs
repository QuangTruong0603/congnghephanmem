namespace GUI
{
    partial class Login
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
            this.txt_dangnhap = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ch_showpass = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_dangky = new MetroSet_UI.Controls.MetroSetButton();
            this.btn_dangnhap = new MetroSet_UI.Controls.MetroSetButton();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_username = new MaterialSkin.Controls.MaterialTextBox();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dangnhap
            // 
            this.txt_dangnhap.AutoSize = true;
            this.txt_dangnhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dangnhap.Location = new System.Drawing.Point(13, 19);
            this.txt_dangnhap.Name = "txt_dangnhap";
            this.txt_dangnhap.Size = new System.Drawing.Size(178, 33);
            this.txt_dangnhap.TabIndex = 2;
            this.txt_dangnhap.Text = "Tên đăng nhập";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.AutoSize = true;
            this.txt_matkhau.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(13, 152);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(121, 33);
            this.txt_matkhau.TabIndex = 4;
            this.txt_matkhau.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.ch_showpass);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_dangnhap);
            this.panel1.Controls.Add(this.txt_matkhau);
            this.panel1.Location = new System.Drawing.Point(259, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 339);
            this.panel1.TabIndex = 6;
            // 
            // ch_showpass
            // 
            this.ch_showpass.AutoSize = true;
            this.ch_showpass.Depth = 0;
            this.ch_showpass.Location = new System.Drawing.Point(19, 263);
            this.ch_showpass.Margin = new System.Windows.Forms.Padding(0);
            this.ch_showpass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ch_showpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.ch_showpass.Name = "ch_showpass";
            this.ch_showpass.ReadOnly = false;
            this.ch_showpass.Ripple = true;
            this.ch_showpass.Size = new System.Drawing.Size(138, 37);
            this.ch_showpass.TabIndex = 7;
            this.ch_showpass.Text = "Hiện mật khẩu";
            this.ch_showpass.UseVisualStyleBackColor = true;
            this.ch_showpass.CheckedChanged += new System.EventHandler(this.ch_showpass_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.btn_dangky);
            this.panel2.Controls.Add(this.btn_dangnhap);
            this.panel2.Location = new System.Drawing.Point(392, 657);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 85);
            this.panel2.TabIndex = 7;
            // 
            // btn_dangky
            // 
            this.btn_dangky.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_dangky.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_dangky.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangky.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_dangky.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_dangky.HoverTextColor = System.Drawing.Color.White;
            this.btn_dangky.IsDerivedStyle = true;
            this.btn_dangky.Location = new System.Drawing.Point(214, 20);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_dangky.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_dangky.NormalTextColor = System.Drawing.Color.White;
            this.btn_dangky.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_dangky.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_dangky.PressTextColor = System.Drawing.Color.White;
            this.btn_dangky.Size = new System.Drawing.Size(126, 41);
            this.btn_dangky.Style = MetroSet_UI.Enums.Style.Light;
            this.btn_dangky.StyleManager = null;
            this.btn_dangky.TabIndex = 1;
            this.btn_dangky.Text = "Đăng ký";
            this.btn_dangky.ThemeAuthor = "Narwin";
            this.btn_dangky.ThemeName = "MetroLite";
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_dangnhap.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_dangnhap.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_dangnhap.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_dangnhap.HoverTextColor = System.Drawing.Color.White;
            this.btn_dangnhap.IsDerivedStyle = true;
            this.btn_dangnhap.Location = new System.Drawing.Point(20, 20);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_dangnhap.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_dangnhap.NormalTextColor = System.Drawing.Color.White;
            this.btn_dangnhap.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_dangnhap.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_dangnhap.PressTextColor = System.Drawing.Color.White;
            this.btn_dangnhap.Size = new System.Drawing.Size(125, 41);
            this.btn_dangnhap.Style = MetroSet_UI.Enums.Style.Light;
            this.btn_dangnhap.StyleManager = null;
            this.btn_dangnhap.TabIndex = 0;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.ThemeAuthor = "Narwin";
            this.btn_dangnhap.ThemeName = "MetroLite";
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // txt_password
            // 
            this.txt_password.AnimateReadOnly = false;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.Hint = "Nhập mật khẩu";
            this.txt_password.LeadingIcon = global::GUI.Properties.Resources.padlock;
            this.txt_password.Location = new System.Drawing.Point(19, 199);
            this.txt_password.MaxLength = 50;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Password = true;
            this.txt_password.Size = new System.Drawing.Size(571, 50);
            this.txt_password.TabIndex = 6;
            this.txt_password.Text = "";
            this.txt_password.TrailingIcon = null;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.AnimateReadOnly = false;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Depth = 0;
            this.txt_username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_username.Hint = "Nhập tên đăng nhập";
            this.txt_username.LeadingIcon = global::GUI.Properties.Resources.user;
            this.txt_username.Location = new System.Drawing.Point(19, 71);
            this.txt_username.MaxLength = 50;
            this.txt_username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(571, 50);
            this.txt_username.TabIndex = 5;
            this.txt_username.Text = "";
            this.txt_username.TrailingIcon = null;
            // 
            // img_logo
            // 
            this.img_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_logo.Image = global::GUI.Properties.Resources._7_Eleven_Logo;
            this.img_logo.Location = new System.Drawing.Point(412, 102);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(307, 180);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 1;
            this.img_logo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 748);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_logo);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.Label txt_dangnhap;
        private System.Windows.Forms.Label txt_matkhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroSet_UI.Controls.MetroSetButton btn_dangky;
        private MetroSet_UI.Controls.MetroSetButton btn_dangnhap;
        private MaterialSkin.Controls.MaterialTextBox txt_username;
        private MaterialSkin.Controls.MaterialTextBox txt_password;
        private MaterialSkin.Controls.MaterialCheckbox ch_showpass;
    }
}

