using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A6IVJJO\\SQLEXPRESS;Initial Catalog=seven_eleven;Integrated Security=True");
        
    }
}
