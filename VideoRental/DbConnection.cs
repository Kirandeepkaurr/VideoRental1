using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Data;

namespace VideoRental
{
    public class DbConnection
    {
       
        public void MakeConnection()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");

            try
            {
                con.Open();
            }
            catch(SqlException e)
            {
                throw (new Exception("Connection failed"));
                
            }



        }
        public void ReadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");
            //query to select all from movies
            SqlCommand cmd = new SqlCommand("Select * from Movies", con);
            SqlDataAdapter da = new SqlDataAdapter();


            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Connection = con;
            try
            {
                con.Open();
            }
            catch (SqlException e)
            {
                throw (new Exception("Data not Readed"));

            }


        }

    }
}
