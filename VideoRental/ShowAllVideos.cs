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
    public partial class ShowAllVideos : Form
    {
        public ShowAllVideos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            //redirect to home
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();
        }
    }
}
