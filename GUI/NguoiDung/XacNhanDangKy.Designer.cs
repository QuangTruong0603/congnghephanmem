namespace GUI
{
    partial class XacNhanDangKy
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
            this.warning = new MetroSet_UI.Controls.MetroSetLabel();
            this.btn_confirm = new MetroSet_UI.Controls.MetroSetButton();
            this.txt_title = new System.Windows.Forms.Label();
            this.txt_otp = new MaterialSkin.Controls.MaterialTextBox();
            this.sendUsername = new System.Windows.Forms.Label();
            this.sendPassword = new System.Windows.Forms.Label();
            this.sendEmail = new System.Windows.Forms.Label();
            this.sendOtp = new System.Windows.Forms.Label();
            this.sendTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.warning);
            this.panel1.Controls.Add(this.btn_confirm);
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Controls.Add(this.txt_otp);
            this.panel1.Location = new System.Drawing.Point(166, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 299);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // warning
            // 
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.IsDerivedStyle = true;
            this.warning.Location = new System.Drawing.Point(82, 170);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(323, 34);
            this.warning.Style = MetroSet_UI.Enums.Style.Light;
            this.warning.StyleManager = null;
            this.warning.TabIndex = 7;
            this.warning.Text = "Mã xác nhận có hiệu lực trong 3 phút";
            this.warning.ThemeAuthor = "Narwin";
            this.warning.ThemeName = "MetroLite";
            // 
            // btn_confirm
            // 
            this.btn_confirm.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_confirm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_confirm.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_confirm.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_confirm.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_confirm.HoverTextColor = System.Drawing.Color.White;
            this.btn_confirm.IsDerivedStyle = true;
            this.btn_confirm.Location = new System.Drawing.Point(168, 207);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_confirm.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_confirm.NormalTextColor = System.Drawing.Color.White;
            this.btn_confirm.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_confirm.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_confirm.PressTextColor = System.Drawing.Color.White;
            this.btn_confirm.Size = new System.Drawing.Size(103, 27);
            this.btn_confirm.Style = MetroSet_UI.Enums.Style.Light;
            this.btn_confirm.StyleManager = null;
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "Xác nhận";
            this.btn_confirm.ThemeAuthor = "Narwin";
            this.btn_confirm.ThemeName = "MetroLite";
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(90, 31);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(291, 38);
            this.txt_title.TabIndex = 2;
            this.txt_title.Text = "Nhập mã xác nhận";
            // 
            // txt_otp
            // 
            this.txt_otp.AnimateReadOnly = false;
            this.txt_otp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_otp.Depth = 0;
            this.txt_otp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_otp.Hint = "Mã xác nhận";
            this.txt_otp.LeadingIcon = global::GUI.Properties.Resources.password;
            this.txt_otp.Location = new System.Drawing.Point(109, 107);
            this.txt_otp.MaxLength = 6;
            this.txt_otp.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_otp.Multiline = false;
            this.txt_otp.Name = "txt_otp";
            this.txt_otp.Size = new System.Drawing.Size(257, 50);
            this.txt_otp.TabIndex = 1;
            this.txt_otp.Text = "";
            this.txt_otp.TrailingIcon = null;
            this.txt_otp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_otp_KeyPress);
            // 
            // sendUsername
            // 
            this.sendUsername.AutoSize = true;
            this.sendUsername.Location = new System.Drawing.Point(54, 122);
            this.sendUsername.Name = "sendUsername";
            this.sendUsername.Size = new System.Drawing.Size(44, 16);
            this.sendUsername.TabIndex = 2;
            this.sendUsername.Text = "label1";
            this.sendUsername.Visible = false;
            // 
            // sendPassword
            // 
            this.sendPassword.AutoSize = true;
            this.sendPassword.Location = new System.Drawing.Point(48, 157);
            this.sendPassword.Name = "sendPassword";
            this.sendPassword.Size = new System.Drawing.Size(44, 16);
            this.sendPassword.TabIndex = 3;
            this.sendPassword.Text = "label2";
            this.sendPassword.Visible = false;
            // 
            // sendEmail
            // 
            this.sendEmail.AutoSize = true;
            this.sendEmail.Location = new System.Drawing.Point(48, 191);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(44, 16);
            this.sendEmail.TabIndex = 4;
            this.sendEmail.Text = "label3";
            this.sendEmail.Visible = false;
            // 
            // sendOtp
            // 
            this.sendOtp.AutoSize = true;
            this.sendOtp.Location = new System.Drawing.Point(51, 225);
            this.sendOtp.Name = "sendOtp";
            this.sendOtp.Size = new System.Drawing.Size(44, 16);
            this.sendOtp.TabIndex = 5;
            this.sendOtp.Text = "label4";
            this.sendOtp.Visible = false;
            // 
            // sendTime
            // 
            this.sendTime.AutoSize = true;
            this.sendTime.Location = new System.Drawing.Point(48, 256);
            this.sendTime.Name = "sendTime";
            this.sendTime.Size = new System.Drawing.Size(44, 16);
            this.sendTime.TabIndex = 6;
            this.sendTime.Text = "label5";
            this.sendTime.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(51, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 37);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // XacNhanDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendTime);
            this.Controls.Add(this.sendOtp);
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.sendPassword);
            this.Controls.Add(this.sendUsername);
            this.Controls.Add(this.panel1);
            this.Name = "XacNhanDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận đăng ký tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XacNhanDangKy_FormClosing);
            this.Load += new System.EventHandler(this.XacNhanDangKy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txt_otp;
        private System.Windows.Forms.Label txt_title;
        private MetroSet_UI.Controls.MetroSetButton btn_confirm;
        private System.Windows.Forms.Label sendUsername;
        private System.Windows.Forms.Label sendPassword;
        private System.Windows.Forms.Label sendEmail;
        private System.Windows.Forms.Label sendOtp;
        private System.Windows.Forms.Label sendTime;
        private MetroSet_UI.Controls.MetroSetLabel warning;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}