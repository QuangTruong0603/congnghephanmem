using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Staff
    {
        public DTO_Staff() { }
        public int staff_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string staff_name { get; set; }
        public DateTime staff_birthday { get; set; }
        public string staff_phone { get; set; }
        public string staff_email { get; set; }
        public string staff_address { get; set; }
        public string staff_gender { get; set; }
        public DateTime staff_start { get; set; }
        public DateTime staff_end { get; set; }
        public string staff_image { get; set; }
        public int staffType_id { get; set; }
        public int staff_enable { get; set; }
    }
}
