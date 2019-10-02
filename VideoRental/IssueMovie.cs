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
    public partial class IssueMovie : Form
    {
        public IssueMovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection to database is made

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");
            string custidd = custid.Text;
            string movieidd = movieid.Text;
            //customer id and movieid is got from text box

            DateTime aDate = DateTime.Now.Date;
           
            //current time is got
            string issuedate= aDate.ToString("yyyy/MM/dd HH:mm::ss");
            //2014 - 04 - 09 15:30:03.447
           

            //DateTime dt = new DateTime(s);
            //issuedate =Convert.ToDateTime(s);
         




            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("INSERT into RentedMovies VALUES (@movieid, @custid, @daterented,NULL)");
            cmd.Parameters.AddWithValue("@movieid", movieidd);
            cmd.Parameters.AddWithValue("@custid", custidd);
            cmd.Parameters.AddWithValue("@daterented", issuedate);

            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            //query is executed to insert record
            Console.WriteLine(recordsAffected);
            con.Close();
            //redirect to home page
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void custid_TextChanged(object sender, EventArgs e)
        {

        }

        private void movieid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();
        }
    }
}
