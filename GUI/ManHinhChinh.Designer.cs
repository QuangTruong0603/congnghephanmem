namespace GUI
{
    partial class ManHinhChinh
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
            this.staffname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // staffname
            // 
            this.staffname.AutoSize = true;
            this.staffname.Location = new System.Drawing.Point(355, 174);
            this.staffname.Name = "staffname";
            this.staffname.Size = new System.Drawing.Size(44, 16);
            this.staffname.TabIndex = 0;
            this.staffname.Text = "label1";
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staffname);
            this.Name = "ManHinhChinh";
            this.Text = "ManHinhChinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManHinhChinh_FormClosing);
            this.Load += new System.EventHandler(this.ManHinhChinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staffname;
    }
}