using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace DAL
{
    public  class DAL_Productcs
    {

        private SqlConnection conn;
        private Connection database = new Connection();

        public DAL_Productcs() { }


        public DataTable getProductManage()
        {
            conn = database.getConnection();

            SqlCommand cmd = new SqlCommand("ManageProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
  

            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));

             adapter.Fill(dt);

            int i = 1;

            foreach (DataRow dr in dt.Rows)
            {
                dr["STT"] = i;
                i++;
            }
          

            return dt;
        }

    }
}
