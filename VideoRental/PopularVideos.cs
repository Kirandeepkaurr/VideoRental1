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
    public partial class PopularVideos : Form
    {
        public PopularVideos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select * from Movies where Rating='G'", con);


            SqlDataAdapter da = new SqlDataAdapter();


            da.SelectCommand = cmd;



            DataTable dt = new DataTable();

            da.Fill(dt);

            //data adapter is filled with rows
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dt;
            //data is binded to data grid view

            gridview.DataSource = bsource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //redirect to home
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();
        }
    }
}
