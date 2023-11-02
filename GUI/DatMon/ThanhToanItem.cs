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
        public ThanhToanItem()
        {
            InitializeComponent();
        }
        private string soluong;

        public string procSoluong
        {
            get { return soluong; }
            set { soluong = value;textBoxSoluong.Text = value; }
        }

        private string name;

        public string procName
        {
            get { return name; }
            set { name = value; labelName.Text = value; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemDeleteClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
