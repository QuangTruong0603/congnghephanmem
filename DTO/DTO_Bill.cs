using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Bill
    {

        public int bill_id {  get; set; }
        public string bill_no { get; set; }
        public DateTime bill_date { get; set; }
        public int bill_total_before { get; set; }
        public int bill_total_after { get; set; }
        public int payment_method_id { get; set; }
        public int customer_id { get; set; }
        public string username { get; set; }

    }
}
