
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Org.BouncyCastle.Ocsp;

namespace GUI
{
    public partial class ReportView : Form
    {

        List<String> list;
        List<DTO_BillDetail> l;
        public ReportView(List<string> list, List<DTO_BillDetail> l)
        {
            InitializeComponent();
            this.list = list;
            this.l = l;
        }

        public String calDiscount(String a, String b)
        {
            String[] strArrA = a.Split(' ');
            String[] strArrB = b.Split(' ');

            int discount = int.Parse(strArrB[0]) - int.Parse(strArrA[0]);

            return discount.ToString() + " VND";
        }


        private void ReportView_Load(object sender, EventArgs e)
        {


            ReportParameter[] param = new ReportParameter[11];

            param[0] = new ReportParameter("title", "HÓA ĐƠN: "+ list[0], false);
            param[1] = new ReportParameter("staff",  list[1], false);
            param[2] = new ReportParameter("customer", list[2], false);
            param[3] = new ReportParameter("date", list[3], false);
            param[4] = new ReportParameter("fprice", list[4], false);
            param[5] = new ReportParameter("lprice", list[5], false);
            param[6] = new ReportParameter("paymentmethod", list[6], false);

            int count = 0;

            foreach(DTO_BillDetail detail in l)
            {
                count = count + detail.quatity;
            }
            param[7] = new ReportParameter("soluong",count.ToString(), false);
            param[8] = new ReportParameter("tongtien", list[4], false);
            param[9] = new ReportParameter("thanhtien", list[5], false);
            param[10] = new ReportParameter("giamgia", calDiscount(list[4], list[5]), false);

            this.reportViewer1.LocalReport.SetParameters(param);

            ReportDataSource rds = new ReportDataSource("databilldetail",l);
            this.reportViewer1.LocalReport.DataSources.Add(rds);


            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
