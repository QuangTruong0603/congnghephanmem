using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Discount2cs
    {
        private SqlConnection conn;
        private Connection database = new Connection();
        public DAL_Discount2cs() 
        {

        }
        public List<DTO_Discount2> GetDiscount()
        {
            List<DTO_Discount2> dTO_Discount= new List<DTO_Discount2>();
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand("select * from Discount", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       
                        DTO_Discount2 Discount = new DTO_Discount2
                        {
                            discount_id = (long)reader["discount_id"],
                            discount_percent = (int)reader["discount_percent"],
                            start = reader.GetDateTime(reader.GetOrdinal("discount_start")),
                            end = reader.GetDateTime(reader.GetOrdinal("discount_end")),
                            product_id = (long)reader["product_id"],
                        
                           


                        };
                        if (Discount.end < DateTime.Now || Discount.start > DateTime.Now)
                        {
                            Discount.status = "OFF  ";
                        }
                        else
                        {
                            Discount.status = "ON";
                        }
                        dTO_Discount.Add(Discount);
                       


                    }
                }
               return dTO_Discount;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return null; }
        }
        public void AddDiscount(long productid, int percent, DateTime start, DateTime end)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert_Discount ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@product_id", SqlDbType.BigInt).Value = productid;
                cmd.Parameters.Add("@discount_percent", SqlDbType.Int).Value = percent;
                cmd.Parameters.Add("@discount_start", SqlDbType.DateTime).Value = start;
                cmd.Parameters.Add("@discount_end", SqlDbType.DateTime).Value = end;

                int aff = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);

            }
        }

        public void DeleteDiscount(long discountid)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete_Discount", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@discount_id", SqlDbType.BigInt).Value = discountid;
               
                int aff = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);

            }
        }
        public void UpdateDiscount(long discountid, int percent, DateTime start, DateTime end, long productid)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update_Discount", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@discount_id", SqlDbType.BigInt).Value = discountid;
                cmd.Parameters.Add("@new_product_id", SqlDbType.BigInt).Value = productid;
                cmd.Parameters.Add("@new_discount_percent", SqlDbType.Int).Value = percent;
                cmd.Parameters.Add("@new_discount_start", SqlDbType.DateTime).Value = start;
                cmd.Parameters.Add("@new_discount_end", SqlDbType.DateTime).Value = end;
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
