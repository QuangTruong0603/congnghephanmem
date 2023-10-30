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

        public int product_id {  get; set; }
        public string product_name { get; set; }
        public string product_barcode { get; set; }
        public int product_price { get; set; }

        public int product_status { get; set; }
        public string procduct_image { get; set; }
        public int unit_id { get; set; }
        public int cate_id { get; set; }
        public int inven_id {  get; set; }
        

    }
}
