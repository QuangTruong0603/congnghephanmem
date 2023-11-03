using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DatMon
{
    public partial class ThanhToanItem : UserControl
    {
        public event EventHandler ItemDeleteClicked;
        public event EventHandler ValueChanged;
        public ThanhToanItem()
        {
            InitializeComponent();
        }
        private string soluong ;

        public int procSoluong
        {
            get 
            { 
                if(textBoxSoluong.Text.Length == 0)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(textBoxSoluong.Text);
                }
                 
            }
          
        }

        private string name;

        public string procName
        {
            get { return name; }
            set { name = value; labelName.Text = value; }
        }

        private string dongia;

        public string procDongia
        {
            get { return dongia; }
            set { dongia = value; labelDongia.Text = value; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemDeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void textBoxSoluong_TextChanged(object sender, EventArgs e)
        {
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ThanhToanItem_Load(object sender, EventArgs e)
        {

        }
    }
}
