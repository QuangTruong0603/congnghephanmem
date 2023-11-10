using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_OrderDetail
    {
        public DTO_OrderDetail() { }
        public string barcode { get; set; }
        public string namepro { get; set; }
        public int quatity { get; set; }
        public string size { get; set; }
        public int price { get; set; }
    }
}
