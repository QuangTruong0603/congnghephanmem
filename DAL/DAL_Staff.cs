using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Staff
    {

        private TripleDES tripleDES = new TripleDES();
        private SqlConnection conn;
        private Connection database = new Connection();
        public DAL_Staff() { 
           
        }


        public bool checkLogin(String username, String password)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();

                String passwordEncrypt = tripleDES.MaHoa(password);

                SqlCommand command = new SqlCommand("CheckLogin", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordEncrypt;
                int count = (int) command.ExecuteScalar();
           
                if (count == 1)
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
                return false;
            }
            catch(Exception ex)
            {
             
                return false;
            }



        }

        public int GetRole(String username)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand("GetRole", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                int roleid = (int) command.ExecuteScalar();
                conn.Close();
                return roleid;


            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public string GetNameStaff(String username)
        {
            String name = "null";

            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand("GetStaff", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    name = reader.GetString(3);
                }

               
                return name;
            }
            catch (Exception ex) { conn.Close(); return name;  }
        }
    
    }
}
