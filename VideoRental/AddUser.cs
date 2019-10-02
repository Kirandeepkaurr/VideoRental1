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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            //this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            //  DataTable dt = new DataTable();
            //con.Open();
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            //con.Close();
            //grid.DataSource = dt;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //connection to database is made

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");
            string firstname = fname.Text;
            string lastname = lname.Text;
            string addres = address.Text;
            string phon = phone.Text;
            //add data of textboxes is got
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("INSERT into Customer VALUES (@firstname, @lastname, @addres,@phon)");
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@addres", addres);
            cmd.Parameters.AddWithValue("@phon", phon);

            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(recordsAffected);
            //query is executed to insert data
            con.Close();

           
            //redirect to home page
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();
        }
    }
}
