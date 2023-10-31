﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            title.BackColor = System.Drawing.Color.Transparent;
            version.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            timer1.Start();
        }


        int start = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
           // progressBar.ForeColor = Color.White;
            start++;
            progressBar.Value = start;
            if(progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                Login lg = new Login();
                this.Hide();
                lg.Show();
            }
        }
    }
}
