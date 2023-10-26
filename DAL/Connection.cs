using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Connection
    {
        private String ConnectionString = "ABC";
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
