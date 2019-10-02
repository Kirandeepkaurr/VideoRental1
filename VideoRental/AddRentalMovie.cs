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
    public partial class AddRentalMovie : Form
    {
        public AddRentalMovie()
        {
            InitializeComponent();
        }

        private void useradd_Click(object sender, EventArgs e)
        {
            //Connection to database is made

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");
            string movieidd = movieid.Text;
            string customeridd = customerid.Text;
            string daterentedd = daterented.Text;
            string datereturnedd = datereturned.Text;
            //all data is of text boxes is got
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("INSERT into RentedMovies VALUES (@movieid, @customerid, @daterented,@datereturned)");
            cmd.Parameters.AddWithValue("@movieid", movieidd);
            cmd.Parameters.AddWithValue("@customerid", customeridd);
            cmd.Parameters.AddWithValue("@daterented", daterentedd);
            cmd.Parameters.AddWithValue("@datereturned", datereturnedd);
          
            //query to insert all data is executed
            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(recordsAffected);
            con.Close();
            //redirect to home page
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();
        }
    }
}
