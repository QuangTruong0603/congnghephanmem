using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class DTO_Order
    {
        public DTO_Order() { }

        public int order_id { get; set; }
        public int customer_id { get; set; }
        public string order_name { get; set; }
        public string order_address { get; set; }

        public string order_phone { get; set; }
        public int order_status { get; set; }
        public int order_total_before { get; set; }
        public int order_total_after { get; set; }

        public string order_paycheck { get; set; }

    }
}
