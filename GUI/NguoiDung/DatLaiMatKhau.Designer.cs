namespace GUI.NguoiDung
{
    partial class NewPassword
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
            this.ch_showPass = new MaterialSkin.Controls.MaterialCheckbox();
            this.waring = new System.Windows.Forms.Label();
            this.btn_createNewPass = new MetroSet_UI.Controls.MetroSetButton();
            this.password = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_titlePassword = new System.Windows.Forms.Label();
            this.otp = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_titleOtp = new System.Windows.Forms.Label();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.sendOtp = new System.Windows.Forms.Label();
            this.sendTime = new System.Windows.Forms.Label();
            this.sendEmail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.ch_showPass);
            this.panel1.Controls.Add(this.waring);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.txt_titlePassword);
            this.panel1.Controls.Add(this.otp);
            this.panel1.Controls.Add(this.txt_titleOtp);
            this.panel1.Location = new System.Drawing.Point(106, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 421);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ch_showPass
            // 
            this.ch_showPass.AutoSize = true;
            this.ch_showPass.Depth = 0;
            this.ch_showPass.Location = new System.Drawing.Point(120, 346);
            this.ch_showPass.Margin = new System.Windows.Forms.Padding(0);
            this.ch_showPass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ch_showPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.ch_showPass.Name = "ch_showPass";
            this.ch_showPass.ReadOnly = false;
            this.ch_showPass.Ripple = true;
            this.ch_showPass.Size = new System.Drawing.Size(138, 37);
            this.ch_showPass.TabIndex = 7;
            this.ch_showPass.Text = "Hiện mật khẩu";
            this.ch_showPass.UseVisualStyleBackColor = true;
            this.ch_showPass.CheckedChanged += new System.EventHandler(this.ch_showPass_CheckedChanged);
            // 
            // waring
            // 
            this.waring.AutoSize = true;
            this.waring.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waring.Location = new System.Drawing.Point(126, 156);
            this.waring.Name = "waring";
            this.waring.Size = new System.Drawing.Size(284, 20);
            this.waring.TabIndex = 6;
            this.waring.Text = "Mã xác nhận có hiệu lực trong 3 phút";
            // 
            // btn_createNewPass
            // 
            this.btn_createNewPass.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_createNewPass.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_createNewPass.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_createNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_createNewPass.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_createNewPass.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_createNewPass.HoverTextColor = System.Drawing.Color.White;
            this.btn_createNewPass.IsDerivedStyle = true;
            this.btn_createNewPass.Location = new System.Drawing.Point(351, 725);
            this.btn_createNewPass.Name = "btn_createNewPass";
            this.btn_createNewPass.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_createNewPass.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_createNewPass.NormalTextColor = System.Drawing.Color.White;
            this.btn_createNewPass.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_createNewPass.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_createNewPass.PressTextColor = System.Drawing.Color.White;
            this.btn_createNewPass.Size = new System.Drawing.Size(127, 32);
            this.btn_createNewPass.Style = MetroSet_UI.Enums.Style.Light;
            this.btn_createNewPass.StyleManager = null;
            this.btn_createNewPass.TabIndex = 4;
            this.btn_createNewPass.Text = "Xác nhận";
            this.btn_createNewPass.ThemeAuthor = "Narwin";
            this.btn_createNewPass.ThemeName = "MetroLite";
            this.btn_createNewPass.Click += new System.EventHandler(this.btn_createNewPass_Click);
            // 
            // password
            // 
            this.password.AnimateReadOnly = false;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Depth = 0;
            this.password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.password.Hint = "Nhập mật khẩu mới";
            this.password.LeadingIcon = global::GUI.Properties.Resources.padlock;
            this.password.Location = new System.Drawing.Point(121, 278);
            this.password.MaxLength = 50;
            this.password.MouseState = MaterialSkin.MouseState.OUT;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Password = true;
            this.password.Size = new System.Drawing.Size(411, 50);
            this.password.TabIndex = 3;
            this.password.Text = "";
            this.password.TrailingIcon = null;
            // 
            // txt_titlePassword
            // 
            this.txt_titlePassword.AutoSize = true;
            this.txt_titlePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titlePassword.Location = new System.Drawing.Point(116, 235);
            this.txt_titlePassword.Name = "txt_titlePassword";
            this.txt_titlePassword.Size = new System.Drawing.Size(219, 29);
            this.txt_titlePassword.TabIndex = 2;
            this.txt_titlePassword.Text = "Nhập mật khẩu mới";
            // 
            // otp
            // 
            this.otp.AnimateReadOnly = false;
            this.otp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.otp.Depth = 0;
            this.otp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.otp.Hint = "Mã xác nhận";
            this.otp.LeadingIcon = global::GUI.Properties.Resources.password;
            this.otp.Location = new System.Drawing.Point(121, 90);
            this.otp.MaxLength = 6;
            this.otp.MouseState = MaterialSkin.MouseState.OUT;
            this.otp.Multiline = false;
            this.otp.Name = "otp";
            this.otp.Size = new System.Drawing.Size(411, 50);
            this.otp.TabIndex = 1;
            this.otp.Text = "";
            this.otp.TrailingIcon = null;
            this.otp.TextChanged += new System.EventHandler(this.otp_TextChanged);
            this.otp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox1_KeyPress);
            // 
            // txt_titleOtp
            // 
            this.txt_titleOtp.AutoSize = true;
            this.txt_titleOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titleOtp.Location = new System.Drawing.Point(116, 43);
            this.txt_titleOtp.Name = "txt_titleOtp";
            this.txt_titleOtp.Size = new System.Drawing.Size(210, 29);
            this.txt_titleOtp.TabIndex = 0;
            this.txt_titleOtp.Text = "Nhập mã xác nhận";
            // 
            // img_logo
            // 
            this.img_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_logo.BackColor = System.Drawing.Color.Transparent;
            this.img_logo.Image = global::GUI.Properties.Resources._7_Eleven_Logo;
            this.img_logo.Location = new System.Drawing.Point(248, 80);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(344, 180);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 6;
            this.img_logo.TabStop = false;
            // 
            // sendOtp
            // 
            this.sendOtp.AutoSize = true;
            this.sendOtp.Location = new System.Drawing.Point(33, 222);
            this.sendOtp.Name = "sendOtp";
            this.sendOtp.Size = new System.Drawing.Size(44, 16);
            this.sendOtp.TabIndex = 7;
            this.sendOtp.Text = "label1";
            this.sendOtp.Visible = false;
            // 
            // sendTime
            // 
            this.sendTime.AutoSize = true;
            this.sendTime.Location = new System.Drawing.Point(36, 255);
            this.sendTime.Name = "sendTime";
            this.sendTime.Size = new System.Drawing.Size(44, 16);
            this.sendTime.TabIndex = 8;
            this.sendTime.Text = "label2";
            this.sendTime.Visible = false;
            // 
            // sendEmail
            // 
            this.sendEmail.AutoSize = true;
            this.sendEmail.Location = new System.Drawing.Point(36, 293);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(44, 16);
            this.sendEmail.TabIndex = 9;
            this.sendEmail.Text = "label1";
            this.sendEmail.Visible = false;
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 798);
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.sendTime);
            this.Controls.Add(this.btn_createNewPass);
            this.Controls.Add(this.sendOtp);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.panel1);
            this.Name = "NewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt lại mật khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPassword_FormClosing);
            this.Load += new System.EventHandler(this.DatLaiMatKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox otp;
        private System.Windows.Forms.Label txt_titleOtp;
        private MetroSet_UI.Controls.MetroSetButton btn_createNewPass;
        private MaterialSkin.Controls.MaterialTextBox password;
        private System.Windows.Forms.Label txt_titlePassword;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.Label waring;
        private MaterialSkin.Controls.MaterialCheckbox ch_showPass;
        private System.Windows.Forms.Label sendOtp;
        private System.Windows.Forms.Label sendTime;
        private System.Windows.Forms.Label sendEmail;
    }
}