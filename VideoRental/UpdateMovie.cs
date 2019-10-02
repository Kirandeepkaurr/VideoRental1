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
    public partial class UpdateMovie : Form
    {
        public UpdateMovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");
            string movieidd = movieid.Text;
            string titlee = title.Text;
            string yearr = year.Text;
            //all data of textbox is got

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("UPDATE Movies SET Title=@title,Year=@year where MovieID=@movieid");
            cmd.Parameters.AddWithValue("@title",titlee);
            cmd.Parameters.AddWithValue("@year", yearr);
            cmd.Parameters.AddWithValue("@movieid",movieidd);


            //query parameter are added


            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            //query is executed
            Console.WriteLine(recordsAffected);
            con.Close();
            
            //redirect to home
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

        private void button3_Click(object sender, EventArgs e)
        {
            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");
            //query to select all from movies
            SqlCommand cmd = new SqlCommand("Select * from Movies", con);

            SqlDataAdapter da = new SqlDataAdapter();


            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            BindingSource bsource = new BindingSource();
            //data is binded to gridview
            bsource.DataSource = dt;

            gridview.DataSource = bsource;
        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
