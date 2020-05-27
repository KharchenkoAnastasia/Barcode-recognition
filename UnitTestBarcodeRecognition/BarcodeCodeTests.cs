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
using System.Drawing.Imaging;
namespace Barcode_recognition.Tests
{
    [TestClass()]
    public class BarcodeCodeTests
    {
        [TestMethod()]
        public void barcodeCodeTest()
        { // arrange
            
            
            Bitmap image_1 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\1.gif");
            Bitmap image_2 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\2.gif");
            Bitmap image_3 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\3.gif");
            Bitmap image_4 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\4.gif");
            Bitmap image_5 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\5.gif");
            Bitmap image_6 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\6.gif");
            Bitmap image_7 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\7.gif");
            Bitmap image_8 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\8.gif");
            Bitmap image_9 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\9.gif");
            Bitmap image_10 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\10.gif");
            Bitmap image_11 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\11.gif");
            Bitmap image_12 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\12.gif");
            Bitmap image_13 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\13.gif");
            Bitmap image_14 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\14.gif");
            Bitmap image_15 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\15.gif");
            Bitmap image_16 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\16.gif");
            Bitmap image_17 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\17.gif");
            Bitmap image_18 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\18.gif");
            Bitmap image_19 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\19.gif");
            Bitmap image_20 = new Bitmap("D:\\ИАД Курсач\\image\\Code\\20.gif");
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
            string[] barcodeOtvet = { "AB2-1234", "222-1234", "2691734", "ABC-abc-1234", "789-abc-1234",
                                       "7821234", "896-abc-1234", "896-abc1234", "89612bc1234", "1112bc1234",
                                        "1259","178hdk","78sdf55","ABC-789J","789-789J",
                                         "TGB7789J","789-144-44","890-144-44","UUU-11","7890-011"};
            ArrayList barcode = new ArrayList();
            string code = "";
            for (int t = 0; t < 20; t++)
            {
                barcode.Clear();
                code = "";
                string otvet = "";
                // act
                BarcodeCode.barcodeCode(ref barcode, imageList[t]);
            //richTextBox1.Text += barcode.Count.ToString();
            for (int i = 0; i < barcode.Count; i++)
            {             
                code += barcode[i];
            }
            // assert
            //Assert.AreEqual(result, code);

                if (code == barcodeOtvet[t]) { otvet = "    Функція повернула вірне значення"; count++; } else otvet = "   Функція повертає невірне значення";
                Debug.WriteLine("Правильна відповідь має бути: " + barcodeOtvet[t] + "   Функція повернула значення: " + code + otvet);
            }
            Debug.Write("Кількість правильно розпізнаних штрих-кодів: " + count);

        }
    }
}