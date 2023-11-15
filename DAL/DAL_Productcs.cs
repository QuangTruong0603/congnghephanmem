using DTO;
using System;
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

                try
                {
                    dr["Ảnh sản phẩm"] = File.ReadAllBytes(path + "\\GUI\\Resources\\Image Products\\" + dr["Path"]);
                }
                catch(Exception ex) { }
               
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
        public DataTable getProductManageKD()
        {
            conn = database.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("ManageProductKD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();


            dt = setDataTable(adapter);

            return dt;
        }

        public DataTable getProductManageKKD()
        {
            conn = database.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("ManageProductKKD", conn);
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
            conn.Close();
            return dt;

        }

        public Boolean enableProduct(String sku)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("EnableProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@product_barcode", SqlDbType.VarChar).Value = sku;
                int aff = cmd.ExecuteNonQuery();

                if (aff == 1)
                {
                    conn.Close();
                    return true;
                }


                conn.Close();
                return false;
            }
            catch(Exception ex)
            {
                conn.Close();
                return false;
            }
        }



        public Boolean checkBarcodeProduct(String barcode )
         {

                try
                {
                    conn = database.getConnection();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("FindProduct", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@product_barcode", SqlDbType.VarChar).Value = barcode;
                    SqlDataReader reader = cmd.ExecuteReader();
                    int count = 0;

                    while (reader.Read())
                    {
                        count++;
                    }

                    if (count == 0)
                    {
                        return true;
                    }

                    return false;
                }
                catch(Exception ex)
                {
                    return false;
                }
            
    
          }

        public Boolean checkBarcodeProduct2(String barcode)
        {

            try
            {
                conn = database.getConnection();
                conn.Open();

                SqlCommand cmd = new SqlCommand("FindProduct2", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@product_barcode", SqlDbType.VarChar).Value = barcode;
                SqlDataReader reader = cmd.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count++;
                }

                if (count == 0)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public String newFileName(string s)
        {
            string[] arr = s.Split('.');

            string formattedDateTime = DateTime.Now.ToString("MM_dd_yyyy-HH_mm_ss");

            return arr[0] + "-" + formattedDateTime + "." + arr[1];


        }

        public Boolean addProduct(DTO_Product product)
        {

            try
            {
                conn = database.getConnection();
                conn.Open();

                string fname = product.procduct_image.ToString();

                String nName = newFileName(fname);

                SqlCommand sqlCommand = new SqlCommand("Insert_Product", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = product.product_name.ToString();
                sqlCommand.Parameters.Add("@product_barcode", SqlDbType.VarChar).Value = product.product_barcode.ToString();
                sqlCommand.Parameters.Add("@product_price", SqlDbType.Int).Value = product.product_price;
                sqlCommand.Parameters.Add("@product_image", SqlDbType.VarChar).Value = nName;
                sqlCommand.Parameters.Add("@product_status", SqlDbType.Int).Value = product.product_status;
                sqlCommand.Parameters.Add("@unit_id", SqlDbType.Int).Value = product.unit_id;
                sqlCommand.Parameters.Add("@cate_id", SqlDbType.Int).Value = product.cate_id;
                sqlCommand.Parameters.Add("@inven_id", SqlDbType.Int).Value = product.inven_id;

                int i = sqlCommand.ExecuteNonQuery();

                return true;



            }
            catch(Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
                return false;
            }


         
        }


        public DTO_Product getProduct(String barcode)
        {
            DTO_Product product = new DTO_Product();

            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("GetInfoProduct", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@product_barcode",SqlDbType.VarChar).Value=barcode;

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    product.product_id = int.Parse(reader["product_id"].ToString());
                    product.product_name = reader["product_name"].ToString();
                    product.product_barcode = reader["product_barcode"].ToString();
                    product.product_price = int.Parse(reader["product_price"].ToString());
                    product.product_status = int.Parse(reader["product_status"].ToString());
                    product.procduct_image = reader["product_image"].ToString();
                    product.unit_id = int.Parse(reader["unit_id"].ToString());
                    product.inven_id = int.Parse(reader["inven_id"].ToString());
                    product.cate_id = int.Parse(reader["cate_id"].ToString());

                }
                return product;

            }
            catch (Exception ex)
            {
                return product;
            }
        }


        public Boolean updateProduct(DTO_Product product)
        {
            try
            {
                conn = database.getConnection();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("Update_Product", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@new_product_name",SqlDbType.NVarChar).Value =  product.product_name.ToString();
                sqlCommand.Parameters.Add("@new_product_barcode",SqlDbType.VarChar).Value = product.product_barcode.ToString();
                sqlCommand.Parameters.Add("@new_product_price", SqlDbType.Int).Value = product.product_price;
                sqlCommand.Parameters.Add("@new_product_image", SqlDbType.VarChar).Value = product.procduct_image.ToString();
                sqlCommand.Parameters.Add("@new_unit_id", SqlDbType.Int).Value = product.unit_id;
                sqlCommand.Parameters.Add("@new_cate_id", SqlDbType.Int).Value = product.cate_id;
                sqlCommand.Parameters.Add("@product_id", SqlDbType.Int).Value = product.product_id;

                int i = sqlCommand.ExecuteNonQuery();

                return true;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }



    }






}
