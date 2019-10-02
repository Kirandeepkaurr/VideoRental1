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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        public void useradd_Click(object sender, EventArgs e)
        {
            //sql connection is made here
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");
            string ratingg = rating.Text;
            string titlee = title.Text;
            string yearr = year.Text;
            string rentalcostt = rentalcost.Text;

            string copiess = copies.Text;
            string plott = plot.Text;
            string genree = genre.Text;
            //Data of all text boxes is got

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("INSERT into Movies VALUES (@rating, @title, @year,@rentalcost, @copies,@plot,@genre)");
            cmd.Parameters.AddWithValue("@rating", ratingg);
            cmd.Parameters.AddWithValue("@title", titlee);
            cmd.Parameters.AddWithValue("@year", yearr);
            cmd.Parameters.AddWithValue("@rentalcost", rentalcostt);
            cmd.Parameters.AddWithValue("@copies", copiess);
            cmd.Parameters.AddWithValue("@plot", plott);
            cmd.Parameters.AddWithValue("@genre", genree);

            //query to insert all data into movies

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
