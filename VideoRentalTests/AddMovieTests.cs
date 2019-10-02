using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace VideoRental.Tests
{
    [TestClass()]
    public class AddMovieTests
    {
        [TestMethod()]
        public void connectionTest()
        {
            DbConnection db = new DbConnection();
            try
            {
                db.MakeConnection();
                
            }
            catch (SystemException e)
            {
                Console.WriteLine("Connection Failed");
                return;
            }
            Assert.Fail("Connection successfully made");
        }
        [TestMethod()]
        public void ReadTest()
        {
            DbConnection db = new DbConnection();
            try
            {
                db.ReadData();

            }
            catch (SystemException e)
            {
                Console.WriteLine("Read Failed");
                return;
            }
            Assert.Fail("Data Read Successfully");

        }




    }
}