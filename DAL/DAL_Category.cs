using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Category
    {

        private Connection database = new Connection();

        private SqlConnection conn;
        public DAL_Category() { }

        public List<string> getNameCatgory()
        {

            List<string> names = new List<string>();

            try
            {

                conn = database.getConnection();
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetNameCategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    names.Add(reader.GetString(0));
                }


                conn.Close();
                return names;
            }
            catch (Exception ex)
            {
                return names;
            }
           

        }

        public int getIdByName(String name)
        {

            int id = -1;

            try
            {
                conn = database.getConnection();
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetIdNameCategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cate_name", SqlDbType.NVarChar).Value = name;

                id = (int)cmd.ExecuteScalar();

                return id;
            }
            catch(Exception ex)
            {
                return id;
            }
            
        }


        public DTO_Category getCategoryById(int id)
        {
            DTO_Category category = new DTO_Category();

            try
            {
                conn = database.getConnection();
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand("GetCategoryById", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;   
                sqlCommand.Parameters.Add("@cate_id",SqlDbType.Int).Value = id;

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    category.cate_id = int.Parse(reader["cate_id"].ToString());
                    category.cate_name = reader["cate_name"].ToString();
                }

                conn.Close();
                return category;

            }
            catch(Exception ex)
            {
                return category;
            }
        }

    }
}
