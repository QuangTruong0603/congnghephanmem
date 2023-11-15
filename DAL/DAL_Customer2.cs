using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Customer2
    {
        private SqlConnection conn;
        private Connection database = new Connection();
        public DAL_Customer2() { }
        public List<DTO_customer> GetProducts()
        {
            List<DTO_customer> dTO_Customers = new List<DTO_customer>();
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand("select * from Customer", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DTO_customer Customer = new DTO_customer
                        {
                            customer_Id = (long)reader["customer_id"],
                            customer_name = reader["customer_name"].ToString(),
                            customer_phone = reader["customer_phone"].ToString(),
                            customer_tichdiem = (long)reader["customer_tichdiem"],
                        };
                        dTO_Customers.Add(Customer);


                    }
                }
                return dTO_Customers;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return null; }

        }
        public void updateTichdiem(long id, long diem)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update_tichdiem_customer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@customer_id", SqlDbType.BigInt).Value = id;
                cmd.Parameters.Add("@new_customer_tichdiem", SqlDbType.BigInt).Value = diem;
                int aff = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
               
            }
        }
        public void AddCustomer(String phone, String ten)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert_Customer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@customer_name", SqlDbType.NVarChar).Value = ten;
                cmd.Parameters.Add("@customer_address", SqlDbType.NVarChar).Value = "0" ;
                cmd.Parameters.Add("@customer_email", SqlDbType.NVarChar).Value = "0";
                cmd.Parameters.Add("@customer_phone", SqlDbType.NVarChar).Value = phone;
                cmd.Parameters.Add("@customer_tichdiem", SqlDbType.BigInt).Value = 1;
                cmd.Parameters.Add("@customer_image", SqlDbType.NVarChar).Value = "0";
                int aff = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);

            }
        }


    }
}
