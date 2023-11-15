using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_product2
    {
        public DTO_product2() { }
        public long product_id { set; get; }
        public string product_name { set; get; }
        public string product_barcode { set; get; }
        public int product_price { set; get; }

        public int product_status { set; get; }
        public string product_image { set; get; }
        public int unit_id { set; get; }
        public int cate_id { set; get; }
        public int inven_id { set; get; }
    }
}
