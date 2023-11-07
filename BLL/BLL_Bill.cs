
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Bill
    {

        private DAL_Bill dAL_Bill = new DAL_Bill();

         public BLL_Bill() { }

        public DataTable getAllBill()
        {
            return dAL_Bill.getDataAllBill();
        }


        public Dictionary<string, string> getBillByNoBill(String nobill) {
            return dAL_Bill.getDetailBill(nobill);
        }

        public String getCustomerOfBill(String nobill)
        {
            return dAL_Bill.getCustomerOfBill(nobill);
        }

        public DataTable getDetailProBill(String nobill)
        {
            return dAL_Bill.getDetailProBill(nobill) ;
        }

        public DataTable getOneBill(String nobill)
        {
            return dAL_Bill.getOneBill(nobill) ;
        }

    }
}
