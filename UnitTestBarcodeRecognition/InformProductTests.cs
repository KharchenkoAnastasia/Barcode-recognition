using Microsoft.VisualStudio.TestTools.UnitTesting;
using Barcode_recognition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SQLite;
using System.Data;
using System.Text;
using System.Collections.Specialized;
using System.Collections;
using System.Data.SQLite;
using System.Data;
using System.Data.Common;
namespace Barcode_recognition.Tests
{
    [TestClass()]
    public class InformProductTests
    {
        [TestMethod()]
        public void searchProductTest()
        {// arrange
            SQLiteConnection db = new SQLiteConnection();
            db.ConnectionString = "Data Source=D:\\ИАД Курсач\\DataBase.db";
            db.Open();
            SQLiteCommand command = new SQLiteCommand("INSERT INTO Product VALUES ('00000000', 'tovar')", db);
             command.ExecuteReader();
            db.Close();
            string barcode= "00000000";
            InformBarcode info = new InformBarcode();
            string otvet = "tovar";
            // act
            string result = info.searchProduct(barcode);
            // assert
            Assert.AreEqual(result, otvet);


            db.Open();
            SQLiteCommand comm = new SQLiteCommand("DELETE FROM Product WHERE barcode='"+barcode+"'", db);
            comm.ExecuteReader();
            db.Close();





        }
    }
}