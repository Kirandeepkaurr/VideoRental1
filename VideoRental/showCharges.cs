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
    public partial class showCharges : Form
    {
        public showCharges()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoRental.Charges[] allRecords = null;

            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");

            //2014 - 04 - 09 15:30:03.447
            //DateTime dt = new DateTime(s);
            //issuedate =Convert.ToDateTime(s);



            SqlCommand cmd = new SqlCommand("Select MovieID,Title,Year from Movies", con);
            con.Open();
            //query is executed


            using (var reader = cmd.ExecuteReader())
            {
          
                var list = new List<VideoRental.Charges>();
                while (reader.Read()) {
                    Int32 movieid= reader.GetInt32(0);
                    String title = reader.GetString(1);

                    String year;

                    //get year of date issued


                    if (reader.IsDBNull(2))
                    {
                        year = "";
                    }
                    else
                    {
                        year = reader.GetString(2);
                    }

                    



                    //if (myyear >= 2014)
                    
                    //{
                    //add fees of 5 incase of movie older than 5 years
                    if (year != "" )
                    {
                        
                            list.Add(new VideoRental.Charges { MovieId = movieid, Title = title, Year = year, fees = 5 });


                        
                     

                    }
                    //else add fees of 2
                    else
                    {
                        list.Add(new VideoRental.Charges { MovieId = movieid, Title = title, Year = year, fees = 2 });

                    }


                    //list.Add(new VideoRental.Charges { MovieId = Convert.ToInt32(reader.GetValue(0)), Title = Convert.ToString(reader.GetValue(1)), Year = Convert.ToInt32(reader.GetValue(2)), fees = 5 });
                    //}
                    //else
                    //{
                    //  list.Add(new VideoRental.Charges { MovieId = 1, Title = "HELLO", Year = 23, fees = 2 });

                    // list.Add(new VideoRental.Charges { MovieId = Convert.ToInt32(reader.GetValue(0)), Title = Convert.ToString(reader.GetValue(1)), Year = Convert.ToInt32(reader.GetValue(2)), fees = 2 });

                    //                    }

                    allRecords = list.ToArray();
                }
                }





            //show record in gridview
                gridview.DataSource = allRecords;





                con.Close();

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

