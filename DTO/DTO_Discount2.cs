using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Discount2
    {
        public DTO_Discount2() { }
        public long discount_id {get;set;}
       
        public int discount_percent { get; set;}
        public DateTime start { get; set;}
        public DateTime end { get; set;}
        public long product_id { get; set;}
        public int pricebefore { get; set;}
        public int priceafter { get; set;}
        public string status { get; set;}
    }
}
