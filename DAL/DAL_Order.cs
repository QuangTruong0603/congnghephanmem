﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Order
    {

        private SqlConnection conn;
        private Connection database = new Connection();

        public DAL_Order() { }



        public DataTable setDataAll(SqlDataAdapter adapter)
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


        public DataTable getAllOrder()
        {

            DataTable dt = new DataTable();

            try
            {

                conn = database.getConnection();
                conn.Open();


                SqlCommand cmd = new SqlCommand("GetAllOrder", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt = setDataAll(adapter);

                return dt;

            }
            catch(Exception ex) {
                conn.Close();
                return dt;
            }
        }


        public DataTable getOrderByStatus(string status)
        {

            DataTable dt = new DataTable();

            try
            {

                conn = database.getConnection();
                conn.Open();


                SqlCommand cmd = new SqlCommand("GetOrderByStatus", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@order_status", SqlDbType.NVarChar).Value = status;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt = setDataAll(adapter);

                return dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                return dt;
            }
        }


        public Dictionary<string,string> getOrderById(int id)
        {
            Dictionary<string, string> dir = new Dictionary<string, string>();

            try
            {

                conn = database.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetOrderById", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@order_id", SqlDbType.Int).Value = id;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dir.Add("madonhang", reader["Mã đơn hàng"].ToString());
                    dir.Add("tennguoinhan", reader["Tên người nhận"].ToString());
                    dir.Add("diachi", reader["Địa chỉ"].ToString());
                    dir.Add("sdt", reader["SDT"].ToString());
                    dir.Add("sotien", reader["Số tiền"].ToString());
                    dir.Add("trangthai", reader["Trạng thái"].ToString());
                    dir.Add("thanhtoan", reader["Thanh toán"].ToString());
                    dir.Add("tkdh", reader["Tên tài khoản đặt hàng"].ToString());
                    dir.Add("sdttkdh", reader["Số điện thoại TKDH"].ToString());
                    dir.Add("ngaytaodon", reader["Ngày tạo đơn"].ToString());
                    dir.Add("sotienbandau", reader["Số tiền ban đầu"].ToString());
                }

                conn.Close();
                return dir;

            }
            catch(Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.ToString());
                return dir;
            }
        }

        public DataTable getOrderDetailById(int id)
        {
            DataTable dt = new DataTable();

            try
            {
                conn = database.getConnection();
                conn.Open();


                SqlCommand cmd = new SqlCommand("GetOrderDetailById", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@order_id",SqlDbType.Int).Value = id;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt = setDataAll(adapter);

                return dt;

            }
            catch(Exception ex) { 
                conn.Close();
                return dt;
            }
        }


        public DataTable getOneOrderById(int id)
        {
            DataTable dt = new DataTable();

            try
            {

                conn = database.getConnection();
                conn.Open();


                SqlCommand cmd = new SqlCommand("GetOneOrderById", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@order_id",SqlDbType.Int).Value=id;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt = setDataAll(adapter);

                return dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                return dt;
            }
        }



        public List<DTO_BillDetail> getListProductOfOrder(int id)
        {
            List<DTO_BillDetail> l = new List<DTO_BillDetail>();

            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetListProductOfOrder", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@order_id", SqlDbType.Int).Value = id;
                   SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    DTO_BillDetail tmp = new DTO_BillDetail();
                    tmp.barcode = sqlDataReader["Mã sản phẩm"].ToString();
                    tmp.namepro = sqlDataReader["Tên sản phẩm"].ToString();
                    tmp.price = int.Parse(sqlDataReader["Số tiền"].ToString());
                    tmp.quatity = int.Parse(sqlDataReader["Số lượng"].ToString());
                    tmp.size = sqlDataReader["Size"].ToString();

                    l.Add(tmp);

                }


                return l;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                conn.Close() ;
                return l;
            }
        }

        public Boolean deleteOrder(int id)
        {
            bool c = false;

            try
            {
                conn = database.getConnection() ;
                conn.Open();


                SqlCommand cmd = new SqlCommand("DeleteOrder", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@order_id", SqlDbType.Int).Value = id;
                int count = cmd.ExecuteNonQuery();

                if(count  == 0)
                {
                    return c;
                }

                c = true;

                return c;


            }
            catch (Exception ex)
            {
                conn.Close();
                return c;
            }
        }
       



    }
}
