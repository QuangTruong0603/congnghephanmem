using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;

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
                SqlDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                conn.Close();
              //  Console.WriteLine(count);   
                return count;


            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int checkUserByEmail(String username)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand("GetStaffByEmail", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = username;
                SqlDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                conn.Close();
               // Console.WriteLine(count);
                return count;

            }
            catch (Exception ex)
            {
                conn.Close();
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



        public DTO_Staff getInformationOfStaff(String email)
        {
            DTO_Staff staff = new DTO_Staff();
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand("GetStaffByEmail", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                SqlDataReader reader = command.ExecuteReader();
                int e;
                while (reader.Read())
                {
                    

                    staff.staff_id = int.Parse(reader["staff_id"].ToString()) ;
                    staff.username = reader["username"].ToString();
                    staff.password = reader["password"].ToString();
                    staff.staff_name = reader["staff_name"].ToString();
                    staff.staff_birthday = DateTime.Parse(reader["staff_birthday"].ToString());
                    staff.staff_phone = reader["staff_phone"].ToString();
                    staff.staff_email= reader["staff_email"].ToString();
                    staff.staff_address = reader["staff_address"].ToString();
                    staff.staff_gender = reader["staff_gender"].ToString();
                    staff.staff_start = DateTime.Parse(reader["staff_start"].ToString());
                    staff.staff_end = DateTime.Parse(reader["staff_end"].ToString());
                    staff.staff_image = reader["staff_image"].ToString();
                    staff.staffType_id = int.Parse(reader["stafftype_id"].ToString());
                    staff.staff_enable =int.Parse(reader["staff_enable"].ToString());

                    
                }

               

                conn.Close();
                return staff;


            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
                return staff;
            }

        }


        public Boolean addStaff(String username, String password, String email)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand("Insert_Staff", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = tripleDES.MaHoa(password);
                command.Parameters.Add("@staff_name", SqlDbType.NVarChar).Value = "Null";
                command.Parameters.Add("@staff_birthday", SqlDbType.Date).Value = "1000-10-10";
                command.Parameters.Add("@staff_phone", SqlDbType.VarChar).Value = "Null";
                command.Parameters.Add("@staff_address", SqlDbType.NVarChar).Value = "Null";
                command.Parameters.Add("@staff_email", SqlDbType.VarChar).Value = email;
                command.Parameters.Add("@staff_gender", SqlDbType.NVarChar).Value = "Null";
                command.Parameters.Add("@staff_start", SqlDbType.Date).Value = "1000-10-10";
                command.Parameters.Add("@staff_end", SqlDbType.Date).Value = "1000-10-10";
                command.Parameters.Add("@staff_image", SqlDbType.VarChar).Value = "Null";
                command.Parameters.Add("@stafftype_id", SqlDbType.Int).Value = 1;
                command.Parameters.Add("@staff_enable", SqlDbType.Int).Value = 1;

                int i = command.ExecuteNonQuery();

                return true;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Boolean UpdatePassword(String email, String password)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();

                String encryptPass = tripleDES.MaHoa(password);

                SqlCommand command = new SqlCommand("UpdatePassword", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@staffemail", SqlDbType.VarChar).Value = email;
                command.Parameters.Add("@newpassword", SqlDbType.VarChar).Value = encryptPass;
                int i = command.ExecuteNonQuery();
                conn.Close();
                if(i == 1)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
                return false;

            }
        }
    
    }
}
