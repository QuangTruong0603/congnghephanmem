using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Product
    {

        public DTO_Product() { }
        private int product_id { set; get; }
        private string product_name { set; get; }
        private string product_barcode { set; get; }
        private int product_price { set; get; }

        private int product_status { set; get; }
        private string procduct_image { set; get; }
        private int unit_id { set; get; }
        private int cate_id { set; get; }
        private int inven_id {  set; get; }
        

    }
}
