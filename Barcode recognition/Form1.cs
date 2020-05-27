using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections;
namespace Barcode_recognition
{
    public partial class BarcodeRecognition : Form
    {
        Bitmap image;
       // Bitmap Temp;
        int numberblack = 0;
        BarcodeEAN barcodeEAN = new BarcodeEAN();
        BarcodeCode barcodeCode = new BarcodeCode();
        InformBarcode barcode = new InformBarcode();
        bool button = false;
        public BarcodeRecognition()
        {
            InitializeComponent();
        }

        private void BarcodeRecognition_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void recognize_Click(object sender, EventArgs e)
        {            
                 numberblack = 0;
                 richTextBox1.Text = "";
             if (button==true)
             {
                 Color[,] All = new Color[image.Width - 1, image.Height - 1];
                 for (int i = 0; i < (image.Width - 1); i++)
                 {
                     for (int j = 0; j < (image.Height - 1); j++)
                     {
                         All[i, j] = image.GetPixel(i, j);
                     }
                 }            
                 numberblack=   barcode.numberblack(image, All);
                 switch (numberblack)
                 {
                     case 30:
                         {
                             richTextBox1.Text += "Код: EAN-13" + "\n";
                             string[] result = barcodeEAN.barcodeEAN13(image, All);
                            if (result.Length != 0)
                            {
                                for (int i = 0; i < 13; i++)
                                    richTextBox1.Text += result[i];
                                richTextBox1.Text += "\nТовар:" + barcode.searchProduct(String.Concat<string>(result));
                            }
                            else richTextBox1.Text = "Штрих-код не розпізнано!";
                         }
                         break;
                     case 22:
                         {                          
                                richTextBox1.Text += "Код:EAN-8" + "\n";
                                string[] result = barcodeEAN.barcodeEAN8(image, All);
                            if (result.Length != 0)
                            {
                                for (int i = 0; i < 8; i++)
                                    richTextBox1.Text += result[i];
                                richTextBox1.Text += "\nТовар:" + barcode.searchProduct(String.Concat<string>(result));
                            }
                            else richTextBox1.Text = "Штрих-код не розпізнано!";
                        }
                         break;
                     default:
                        {
                            richTextBox1.Text += "Код:Code39" + "\n";
                            ArrayList barcode = new ArrayList();
                            string code = "";
                            BarcodeCode.barcodeCode(ref barcode, image);
                            if (barcode.Count != 0)
                            {
                                for (int i = 0; i < barcode.Count; i++)
                                {
                                    richTextBox1.Text += barcode[i];
                                    code += barcode[i];
                                }
                                richTextBox1.Text += "\nТовар:" + this.barcode.searchProduct(code);
                            }
                            else richTextBox1.Text = "Штрих-код не розпізнано!";
                        }
                         break;
                 }
             }
             else MessageBox.Show("Завантажте зображення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void download_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text = "";          
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG | All files(*.*) | *.* ";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {  
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                    button = true;
                    recognize.Enabled = true;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Не відкрився файл!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
