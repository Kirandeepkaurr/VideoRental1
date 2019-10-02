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
    public partial class DeleteRentalMovies : Form
    {
        public DeleteRentalMovies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection to database is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");
            string custidd = custid.Text;
            string movieidd = movieid.Text;
            //movie and cusomer id from textbox is got
            


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("DELETE from RentedMovies where MovieIDFK=@movieid and CustIDFK=@custid");
            cmd.Parameters.AddWithValue("@movieid", movieidd);
            cmd.Parameters.AddWithValue("@custid", custidd);




            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            //query to delete rows is executed
            Console.WriteLine(recordsAffected);
            con.Close();
            //redirect to home page
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();
        }

        private void DeleteRentalMovies_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");
            //query to select all from movies
            SqlCommand cmd = new SqlCommand("Select * from RentedMovies", con);

            SqlDataAdapter da = new SqlDataAdapter();


            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            BindingSource bsource = new BindingSource();
            //data is binded to gridview
            bsource.DataSource = dt;
            gridview.DataSource = bsource;

        }
    }
}
