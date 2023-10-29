﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
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

        private string workingDirectory = Environment.CurrentDirectory;

       

        public DAL_Productcs() { }


        public DataTable setDataTable(SqlDataAdapter adapter)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("STT", typeof(int));

            adapter.Fill(dt);

            dt.Columns.Add("Ảnh sản phẩm", Type.GetType("System.Byte[]"));

            int i = 1;

            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName.ToString();

            foreach (DataRow dr in dt.Rows)
            {
                dr["STT"] = i;
                i++;

                dr["Ảnh sản phẩm"] = File.ReadAllBytes(path + "\\GUI\\Resources\\Image Products\\" + dr["Path"]);
            }


            return dt;
        }


        public DataTable getProductManage()
        {
            conn = database.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("ManageProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();


             dt = setDataTable(adapter);

            return dt;
        }


 


        public Boolean DisableProduct(String sku)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("DisableProduct", conn);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.Add("@product_barcode", SqlDbType.VarChar).Value = sku;
                int aff = cmd.ExecuteNonQuery();

                if(aff == 1)
                {
                    conn.Close();
                    return true;
                }

                conn.Close();
                return false;


            }
            catch (Exception ex)
            {
                conn.Close() ;
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public DataTable findOneProduct(String barcode)
        {
            conn = database.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("FindProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@product_barcode", SqlDbType.VarChar).Value = barcode;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            dt = setDataTable(adapter);

            return dt;

        }

    }
}
