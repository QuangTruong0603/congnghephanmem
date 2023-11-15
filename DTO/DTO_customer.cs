using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_customer
    {
        public long customer_Id { get; set; }
        public string customer_name { get; set; }
        public string customer_address { get; set; }
        public string customer_phone { get; set;}
        public string customer_email { get; set;}
        public long customer_tichdiem { get; set; }
        public string customer_image { get; set;}
    }
}
