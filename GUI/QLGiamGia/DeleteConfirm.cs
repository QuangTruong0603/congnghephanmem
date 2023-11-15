using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QLGiamGia
{
    public partial class DeleteConfirm : Form
    {
        private long id;
        private TrangChuGiamGia tc;
        public DeleteConfirm(long id, TrangChuGiamGia tc)
        {
            InitializeComponent();
            this.id = id;
            this.tc = tc;
        }

        private void DeleteConfirm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DAL_Discount2cs dAL_Discount2Cs = new DAL_Discount2cs();
            dAL_Discount2Cs.DeleteDiscount(id);
            TrangChuGiamGia trangChuGiamGia = new TrangChuGiamGia();
            tc.Hide();
            this.Close();
            trangChuGiamGia.Show();
        }
    }
}
