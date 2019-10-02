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
    public partial class MoviesOutPresent : Form
    {
        public MoviesOutPresent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("  Select Movies.* from Movies inner join RentedMovies on RentedMovies.MovieIDFK=Movies.MovieID  where RentedMovies.DateReturned is  null", con);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();

            da.Fill(dt);

            BindingSource bsource = new BindingSource();

            bsource.DataSource = dt;

            gridview.DataSource = bsource;
        }
    }
}
