using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormDosyaVeKlasorIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo DI = Directory.CreateDirectory("C:\\Ornek\\deneme");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool klasorvarmi = Directory.Exists("C:\\Ornek\\deneme");

            if (klasorvarmi)
            {
                // Directory.Delete("C:\\Ornek\\deneme");
                Directory.Delete("C:\\Ornek\\deneme", true);//klasör içinde dosya varsa da sil
                MessageBox.Show("Klasör silindi");
            }
            else
            {
                MessageBox.Show("Klasör bulunamadı");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Directory.Move("C:\\Ornek\\deneme", textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream f = File.Create("C:\\Ornek\\deneme\\merhaba.xls");
            f.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.Move("C:\\Ornek\\deneme\\merhaba.txt", "C:\\resim\\merhaba2.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool dosyavarmi = File.Exists("C:\\Ornek\\deneme\\merhaba.txt");
            if (dosyavarmi)
            {
                File.Delete("C:\\Ornek\\deneme\\merhaba.txt");
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            File.Copy("C:\\Ornek\\deneme\\merhaba.txt","C:\\deneme\\merhaba.txt");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            File.AppendAllText("C:\\deneme\\merhaba.xls", txt_veri.Text);
        }
        

        private void button9_Click(object sender, EventArgs e)
        {
            string okunandeger=File.ReadAllText("C:\\deneme\\merhaba.xls");
            MessageBox.Show(okunandeger);
        }
    }
}
