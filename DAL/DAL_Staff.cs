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
                conn.Close();
                return -1;
            }
        }

        public int checkUserByUsername(String username)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand("GetStaff", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                int count = command.ExecuteNonQuery();
                conn.Close();
                return count;


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

                conn.Close();
                return name;
            }
            catch (Exception ex) { conn.Close(); return name;  }
        }

        public Boolean addStaff(String username, String password, String email)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand("Insert_Staff", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = tripleDES.MaHoa(password);
                command.Parameters.Add("@satff_name", SqlDbType.VarChar).Value = "Null";
                command.Parameters.Add("@staff_birthday", SqlDbType.Date).Value = "1000-10-10";
                command.Parameters.Add("@staff_phone", SqlDbType.VarChar).Value = "Null";
                command.Parameters.Add("@staff_address", SqlDbType.VarChar).Value = "Null";
                command.Parameters.Add("@staff_email", SqlDbType.VarChar).Value = email;
                command.Parameters.Add("@staff_gender", SqlDbType.VarChar).Value = "Null";
                command.Parameters.Add("@staff_start", SqlDbType.Date).Value = "1000-10-10";
                command.Parameters.Add("@staff_start", SqlDbType.Date).Value = "1000-10-10";
                command.Parameters.Add("@staff_image", SqlDbType.VarChar).Value = "Null";
                command.Parameters.Add("@stafftype_id", SqlDbType.Int).Value = 1;
                command.Parameters.Add("@staff_enable", SqlDbType.Int).Value = 1;

                int i = command.ExecuteNonQuery();

                return true;


            }
            catch (Exception ex)
            {
                return false;
            }
        }


    
    }
}
