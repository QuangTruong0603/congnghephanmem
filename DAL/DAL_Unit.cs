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
    public  class DAL_Unit
    {
        private Connection database = new Connection();

        private SqlConnection conn;

        public DAL_Unit() { }


        public List<string> getNameUnit()
        {
            List<string> names = new List<string>();

            try
            {
                conn = database.getConnection();
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetNameUnit", conn);
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

        public int getIdUnitName(String name)
        {

            int id = -1;

            try
            {
                conn = database.getConnection();
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetIdNameUnit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@unit_name", SqlDbType.NVarChar).Value = name;

                id = (int)cmd.ExecuteScalar();

                return id;
            }
            catch (Exception ex)
            {
                return id;
            }


        }

        public DTO_Unit getUnitById(int id)
        {
            DTO_Unit unit = new DTO_Unit();

            try
            {
                conn = database.getConnection();
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetUnitById", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@unit_id",SqlDbType.Int) .Value = id;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    unit.unit_id = int.Parse(reader["unit_id"].ToString());
                    unit.unit_name = reader["unit_name"].ToString();

                          

                }

                conn.Close();
                return unit;

            }
            catch(Exception ex)
            {
                return unit;
            }
        }



    }
}
