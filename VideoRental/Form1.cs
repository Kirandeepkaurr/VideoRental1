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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            
            AddUser Check = new AddUser();
            Check.Show();
            this.Hide();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMovie Check = new AddMovie();
            Check.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddRentalMovie Check = new AddRentalMovie();
            Check.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteUser Check = new DeleteUser();
            Check.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            UpdateCustomer Check = new UpdateCustomer();
            Check.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateMovie Check = new UpdateMovie();
            Check.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateRentedMovies Check = new UpdateRentedMovies();
            Check.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowAllVideos Check = new ShowAllVideos();
            Check.Show();
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            VideosoutPresent Check = new VideosoutPresent();
            Check.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IssueMovie Check = new IssueMovie();
            Check.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteMovie Check = new DeleteMovie();
            Check.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteRentalMovies Check = new DeleteRentalMovies();
            Check.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ReturnMovie Check = new ReturnMovie();
            Check.Show();
            this.Hide();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            showCharges Check = new showCharges();
            Check.Show();
            this.Hide();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            MaxBorrower Check = new MaxBorrower();
            Check.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PopularVideos Check = new PopularVideos();
            Check.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ShowAllUsers Check = new ShowAllUsers();
            Check.Show();
            this.Hide();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //redirect to home
            ShowRentedMovies Check = new ShowRentedMovies();
            Check.Show();
            this.Hide();
        }
    }
}
