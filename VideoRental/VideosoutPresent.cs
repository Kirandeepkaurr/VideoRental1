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
    public partial class VideosoutPresent : Form
    {
        public VideosoutPresent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");

            SqlCommand cmd = new SqlCommand("  Select Movies.* from Movies inner join RentedMovies on RentedMovies.MovieIDFK=Movies.MovieID  where RentedMovies.DateReturned is  null", con);

            //query to find whose data returned is null
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();

            da.Fill(dt);

            BindingSource bsource = new BindingSource();
            //bind data to grid view
            bsource.DataSource = dt;

            gridview.DataSource = bsource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //redirect to home
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();
        }
    }
}
