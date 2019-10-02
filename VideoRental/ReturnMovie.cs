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
    public partial class ReturnMovie : Form
    {
        public ReturnMovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");
            string custidd = custid.Text;
            string movieidd = movieid.Text;

            //customer and movie id is got

            DateTime aDate = DateTime.Now.Date;
            //get current data and time

            string returndate = aDate.ToString("yyyy/MM/dd HH:mm::ss");
            //2014 - 04 - 09 15:30:03.447
            //DateTime dt = new DateTime(s);
            //issuedate =Convert.ToDateTime(s);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
        
            
            cmd.CommandText = ("UPDATE RentedMovies SET DateReturned=@returndate where MovieIDFK=@movieid and CustIDFK=@custid;");
            cmd.Parameters.AddWithValue("@movieid", movieidd);
            cmd.Parameters.AddWithValue("@custid", custidd);
            cmd.Parameters.AddWithValue("@returndate", returndate);

            //update query to update date returned column



            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(recordsAffected);
            con.Close();
            //redirect to home
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            //redirct to home page
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
    }
}
