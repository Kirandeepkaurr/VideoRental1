using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace VideoRental
{
    public partial class MaxBorrower : Form
    {
        public MaxBorrower()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");

            SqlCommand cmd = new SqlCommand(" SELECT TOP 1 CustIDFK FROM RentedMovies GROUP BY CustIDFK ORDER BY count(CustIDFK) desc; ", con);
            con.Open();

            Int32 custId=2;
            //query is executed using reader
            using (var reader = cmd.ExecuteReader())
            {


                while (reader.Read())
                {
                    custId = reader.GetInt32(0);

                    break;
                }
            }
            //customer id with max borrowing is got
            con.Close();

            con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");

            cmd = new SqlCommand("Select * from Customer where CustID=@custid", con);
            cmd.Parameters.AddWithValue("@custid", custId);
            //select all details of that customer
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            //bind the data of that customer to datagridview
            da.Fill(dt);

            BindingSource bsource = new BindingSource();

            bsource.DataSource = dt;

            gridview.DataSource = bsource;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //redirct to home page
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();
        }
    }
}
