using Microsoft.VisualStudio.TestTools.UnitTesting;
using Barcode_recognition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Specialized;
using System.Collections;
using System.Diagnostics;
//using System.Drawing.Imaging.Metafile;
using System.Drawing.Imaging;


namespace Barcode_recognition.Tests
{
    [TestClass()]
    public class BarcodeEANTests
    {
        [TestMethod()]
        public void barcodeEAN13Test()
        {
            // arrange
            BarcodeEAN barcode = new BarcodeEAN();
            Bitmap image_1 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\1.gif");
            Bitmap image_2 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\2.gif");
            Bitmap image_3 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\3.gif");
            Bitmap image_4 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\4.gif");
            Bitmap image_5 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\5.jpg");
            Bitmap image_6 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\6.jpg");
            Bitmap image_7 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\7.jpg");
            Bitmap image_8 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\8.gif");
            Bitmap image_9 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\9.gif");
            Bitmap image_10 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\10.gif");
            Bitmap image_11 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\11.gif");
            Bitmap image_12 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\12.gif");
            Bitmap image_13 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\13.gif");
            Bitmap image_14 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\14.gif");
            Bitmap image_15 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\15.gif");
            Bitmap image_16 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\16.gif");
            Bitmap image_17 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\17.gif");
            Bitmap image_18 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\18.gif");
            Bitmap image_19 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\19.gif");
            Bitmap image_20 = new Bitmap("D:\\ИАД Курсач\\image\\EAN13\\20.gif");
            List<Bitmap> imageList = new List<Bitmap>();
            imageList.Add(image_1);
            imageList.Add(image_2);
            imageList.Add(image_3);
            imageList.Add(image_4);
            imageList.Add(image_5);
            imageList.Add(image_6);
            imageList.Add(image_7);
            imageList.Add(image_8);
            imageList.Add(image_9);
            imageList.Add(image_10);
            imageList.Add(image_11);
            imageList.Add(image_12);
            imageList.Add(image_13);
            imageList.Add(image_14);
            imageList.Add(image_15);
            imageList.Add(image_16);
            imageList.Add(image_17);
            imageList.Add(image_18);
            imageList.Add(image_19);
            imageList.Add(image_20);
            int count = 0;
            string[] barcodeOtvet = { "9780201379624", "9780202279626", "8880202279624", "8870211279616", "8870202279625", "1870211279613", "1870211272003", "1440211272008", "9940211272005", "9940211272012",
                                      "9702230379628", "9802230379625","9812230379624","981223037978","9780278379626","1110278379629","1110108379638","1220108379634","8220108379637","8221978379635"};
            string barcodeEAN = "";
            string[] result;
            for (int t = 0; t < 20; t++)
            {
                string otvet = "";
                Color[,] All = new Color[imageList[t].Width - 1, imageList[t].Height - 1];
            for (int i = 0; i < (imageList[t].Width - 1); i++)
            {
                for (int j = 0; j < (imageList[t].Height - 1); j++)
                {
                    All[i, j] = imageList[t].GetPixel(i, j);
                }
            }
                // act
                barcodeEAN = "";
                result = barcode.barcodeEAN13(imageList[t], All);
            for (int i = 0; i < 13; i++)
            {
                barcodeEAN += result[i];
            }

                // assert
                
                if (barcodeEAN == barcodeOtvet[t]) { otvet = "    Функція повернула вірне значення"; count++; } else otvet = "   Функція повертає невірне значення";
                Debug.WriteLine("Правильна відповідь має бути: " + barcodeOtvet[t] + "   Функція повернула значення: " + barcodeEAN + otvet);
            }
            Debug.Write("Кількість правильно розпізнаних штрих-кодів: " + count);

        }

        [TestMethod()]
        public void barcodeEAN8Test()
        {    // arrange
            BarcodeEAN barcode = new BarcodeEAN();
            //Bitmap image= new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\EAN8.gif");
            
            Bitmap image_1 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\1.gif");
            Bitmap image_2 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\2.gif");
            Bitmap image_3 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\3.gif");
            Bitmap image_4 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\4.gif");
            Bitmap image_5 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\5.jpg");
            Bitmap image_6 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\6.gif");
            Bitmap image_7 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\7.gif");
            Bitmap image_8 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\8.gif");
            Bitmap image_9 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\9.gif");
            Bitmap image_10 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\10.gif");
            Bitmap image_11 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\11.gif");
            Bitmap image_12 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\12.gif");
            Bitmap image_13 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\13.gif");
            Bitmap image_14 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\14.gif");
            Bitmap image_15 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\15.gif");
            Bitmap image_16 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\16.gif");
            Bitmap image_17 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\17.gif");
            Bitmap image_18 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\18.gif");
            Bitmap image_19 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\19.gif");
            Bitmap image_20 = new Bitmap("D:\\ИАД Курсач\\image\\EAN8\\20.gif");
            List<Bitmap> imageList = new List<Bitmap>();
            imageList.Add(image_1);
            imageList.Add(image_2);
            imageList.Add(image_3);
            imageList.Add(image_4);
            imageList.Add(image_5);
            imageList.Add(image_6);
            imageList.Add(image_7);
            imageList.Add(image_8);
            imageList.Add(image_9);
            imageList.Add(image_10);
            imageList.Add(image_11);
            imageList.Add(image_12);
            imageList.Add(image_13);
            imageList.Add(image_14);
            imageList.Add(image_15);
            imageList.Add(image_16);
            imageList.Add(image_17);
            imageList.Add(image_18);
            imageList.Add(image_19);
            imageList.Add(image_20);
            int count = 0;
            string [] barcodeOtvet = { "90311017", "80211013", "90333330" ,"12345670","88345673", "81005673", "18762471" , "22762474", "22112477", "22112118",
                                      "92211209","97211204","97211105","97288107","77288103","77988102","67988105","12088102","19088105","99088101"};
            string barcodeEAN = "";
            string[] result;
            for (int t = 0; t < 20; t++)
            {
                string otvet = "";
             
                Color[,] All = new Color[imageList[t].Width - 1, imageList[t].Height - 1];
            for (int i = 0; i < (imageList[t].Width - 1); i++)
              {
                  for (int j = 0; j < (imageList[t].Height - 1); j++)
                  {
                      All[i, j] = imageList[t].GetPixel(i, j);
                  }
              }
                // act
                barcodeEAN = "";
            result= barcode.barcodeEAN8(imageList[t], All);
            for(int i=0; i < 8; i++)
            {
                barcodeEAN += result[i];
            }
            
                // assert
               // Assert.AreEqual(barcodeEAN, barcoderesult[t]);
               if(barcodeEAN== barcodeOtvet[t]) { otvet = "    Функція повернула вірне значення"; count++; } else otvet = "   Функція повертає невірне значення";
                Debug.WriteLine("Правильна відповідь має бути: "  + barcodeOtvet[t]+"   Функція повернула значення: " +barcodeEAN + otvet);
            }
            Debug.Write("Кількість правильно розпізнаних штрих-кодів: " + count);

        }
    }
}