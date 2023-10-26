using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace DAL
{
    public class DAL_Staff : DBConnection
    {
        public DAL_Staff() { }
       
        public String checkLogin(string username, string password) 
        {
            
            conn.Close();
            conn.Open();
            SqlCommand command = new SqlCommand("CheckLogin", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return reader["username"].ToString();
            }
                return reader.ToString();
            conn.Close();
        }

    }
}
