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

namespace GUI
{
    public partial class PrintReview : Form
    {

        private Dictionary<string, string> dic;
        private int idOrder;
        private List<DTO_BillDetail> list;

        public PrintReview(Dictionary<string, string> dic, int idOrder, List<DTO_BillDetail> list)
        {
            InitializeComponent();
            this.dic = dic;
            this.idOrder = idOrder;
            this.list = list;
        }

        private void PrintReview_Load(object sender, EventArgs e)
        {

         

            ReportParameter[] param = new ReportParameter[12];



            int fprice = 0;
            int lprice = 0;
            string tkdh = "";

            foreach (KeyValuePair<string, string> item in dic)
            {



                if (item.Key.Equals("madonhang"))
                {
                    param[0] = new ReportParameter("madonhang", item.Value, false);

                }


                if (item.Key.Equals("tennguoinhan"))
                {
                    param[1] = new ReportParameter("tennguoinhan", item.Value, false);

                }

                if (item.Key.Equals("diachi"))
                {
                    param[2] = new ReportParameter("diachi", item.Value, false);
                }

                if (item.Key.Equals("sdt"))
                {
                    param[3] = new ReportParameter("sdt", item.Value, false);
                }

                if (item.Key.Equals("sotien"))
                {
                    param[4] = new ReportParameter("thanhtien", item.Value +" VND", false);

                    lprice = int.Parse(item.Value.ToString());
                }


                if (item.Key.Equals("trangthai"))
                {
                    param[5] = new ReportParameter("trangthaidonhang", item.Value, false);
                }

                if (item.Key.Equals("thanhtoan"))
                {
                    param[6] = new ReportParameter("thanhtoan", item.Value, false);
                }

                if (item.Key.Equals("tkdh"))
                {
                   
                    tkdh = item.Value;
                }

                if (item.Key.Equals("sdttkdh"))
                {
                    param[7] = new ReportParameter("tkdh", tkdh +"-"+ item.Value, false);
                }

                if (item.Key.Equals("ngaytaodon"))
                {
                    param[8] = new ReportParameter("ngaytaodon", item.Value, false);
                }

                if (item.Key.Equals("sotienbandau"))
                {
                    param[9] = new ReportParameter("sotien", item.Value +" VND", false);
                    fprice = int.Parse(item.Value.ToString());
                }



            }

            int delivery = lprice - fprice;

            param[10] = new ReportParameter("phivanchuyen", delivery.ToString()+ " VND", false);


            param[11] = new ReportParameter("total",list.Count().ToString(),false);


            this.reportViewer1.LocalReport.SetParameters(param);

            ReportDataSource rds = new ReportDataSource("orderDetail", list);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();


        }
    }
}
