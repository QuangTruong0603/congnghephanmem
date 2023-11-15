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
    public partial class product_item : UserControl
    {
        public event EventHandler ItemClicked;
        public product_item()
        {
            InitializeComponent();
        }

        private void product_item_Load(object sender, EventArgs e)
        {

        }

        private Image imageItem;

        public Image procImage
        {
            get { return imageItem; }
            set { imageItem = value;pictureBoxItem.Image = value; }
        }

        private string Name;

        public string ProcName
        {
            get { return Name; }
            set { Name = value;labelName.Text = value; }
        }
        private string price;

        public string ProcPrice
        {
            get { return price; }
            set { price = value;  }
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
