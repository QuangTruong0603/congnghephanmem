using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace DAL
{
    public class DAL_Bill
    {
        private Connection database = new Connection();

        private SqlConnection conn;

        public DAL_Bill() { }


        public DataTable setDataAllBill(SqlDataAdapter adapter)
        {

            DataTable dt = new DataTable();

            try
            {
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
            catch(Exception ex)
            {
                return dt;
            }

        }

        public DataTable getDataAllBill()
        {
            DataTable dt = new DataTable();
            try
            {
                conn = database.getConnection();
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetAllBill", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt = setDataAllBill(adapter);

                return dt;

            }
            catch(Exception ex)
            {
                conn.Close();
                return dt;
            }
        }


        public DataTable setDetailBill(SqlDataAdapter adapter)
        {
            DataTable dt = new DataTable();

            try
            {
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
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable getDetailProBill(String nobill)
        {
            DataTable dt = new DataTable();
            try
            {
                conn = database.getConnection();
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetListProductOfBill", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@bill_no",SqlDbType.VarChar).Value = nobill;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt = setDetailBill(adapter);

                return dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                return dt;
            }
        }

        public Dictionary<string, string> getDetailBill(String nonill)
        {
            Dictionary<string, string> dir = new Dictionary<string, string>();

            try
            {
                conn = database.getConnection();
                conn.Open();

                SqlCommand command = new SqlCommand("GetBillByNoBill", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@bill_no", SqlDbType.VarChar).Value = nonill;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dir.Add("bill_date", reader["Thời gian"].ToString());
                    dir.Add("bill_total_after", reader["Số tiền"].ToString());
                    dir.Add("bill_total_before", reader["Số tiền ban đầu"].ToString());
                    dir.Add("paymentmethod_name", reader["Phương thức thanh toán"].ToString());
                    dir.Add("staff_name", reader["Nhân viên bán hàng"].ToString());

                }

                return dir;

            }
            catch (Exception ex)
            {
                conn.Close();
                return dir;
            }

        }


        public String getCustomerOfBill(String nobill)
        {
            String res = "Null - Null";

            try
            {
                conn = database.getConnection();
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetCustomerOfBill", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@bill_no",SqlDbType.VarChar).Value = nobill;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    res = reader["customer_name"].ToString() + " - " + reader["customer_phone"].ToString();
                }

                conn.Close();

                return res;
            }
            catch(Exception ex)
            {
                conn.Close ();
                return res;
            }
        }


        public DataTable getOneBill(String nobill)
        {
            DataTable dt = new DataTable();
            try
            {
                conn = database.getConnection();
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetBillByNoBill", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@bill_no", SqlDbType.VarChar).Value = nobill;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt = setDetailBill(adapter);

                return dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                return dt;
            }
        }



    }
}
