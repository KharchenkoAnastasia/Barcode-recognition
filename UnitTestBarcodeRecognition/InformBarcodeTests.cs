using Microsoft.VisualStudio.TestTools.UnitTesting;
using Barcode_recognition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Barcode_recognition.Tests
{
    [TestClass()]
    public class InformBarcodeTests
    {
        [TestMethod()]
        public void numberblackTest()
        {
            // arrange
            InformBarcode barcode = new InformBarcode();
            Bitmap image = new Bitmap("D:\\ИАД Курсач\\image\\EAN8.gif");
            
            int result;
            Color[,] All = new Color[image.Width - 1, image.Height - 1];
            for (int i = 0; i < (image.Width - 1); i++)
            {
                for (int j = 0; j < (image.Height - 1); j++)
                {
                    All[i, j] = image.GetPixel(i, j);
                }
            }
            // act
            result = barcode.numberblack(image,All);
            

            // assert
            Assert.AreEqual(result, 22);
        }
    }
}