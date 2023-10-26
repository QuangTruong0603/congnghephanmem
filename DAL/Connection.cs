using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        private String ConnectionString = "Data Source=MSI;Initial Catalog=databasev1;Integrated Security=True";
        private SqlConnection conn = null;


        public Connection() { }

        public SqlConnection getConnection()
        {

            conn = new SqlConnection(ConnectionString);

            return conn;
        }

        public void close()
        {
            conn.Close();
        }
    }
}
