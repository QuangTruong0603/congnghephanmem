using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{

    
    public class BLL_Product
    {

        private DAL_Productcs dAL_Productcs = new DAL_Productcs();

        public BLL_Product() { }

        public DataTable getProductManage()
        {
            return dAL_Productcs.getProductManage();
        }

        public Boolean DisableProduct(String sku)
        {
            return dAL_Productcs.DisableProduct(sku);
        }

        public DataTable findProduct(String barcode)
        {
            return dAL_Productcs.findOneProduct(barcode);
        }
    }
}
