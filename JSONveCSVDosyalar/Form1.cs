using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONveCSVDosyalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Personel> liste = new List<Personel>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Personel p = new Personel();
                p.ID = Guid.NewGuid();
                p.Isim = FakeData.NameData.GetFirstName();
                p.Soyisim = FakeData.NameData.GetSurname();
                p.Email = p.Isim + "." + p.Soyisim + "@" + FakeData.NetworkData.GetDomain();
                p.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();
                liste.Add(p);
            }
        }

        private void btn_json_olustur_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:\\JSON\\"))
            {
                Directory.CreateDirectory("C:\\JSON\\");
            }

            string veri = Newtonsoft.Json.JsonConvert.SerializeObject(liste);
            File.WriteAllText("C:\\JSON\\personeller.json", veri);
        }

        private void btn_json_oku_Click(object sender, EventArgs e)
        {
            string veri = File.ReadAllText("C:\\JSON\\personeller.json");
            List<Personel> personeller = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personel>>(veri);
            lst_personeller.DataSource = personeller;
            //   lst_personeller.DisplayMember = "Isim";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("C:\\CSV\\personeller.csv"))
            {
                StreamWriter dosya = new StreamWriter("C:\\CSV\\personeller.csv");
                CsvWriter csv = new CsvWriter(dosya, CultureInfo.CurrentCulture);
                csv.WriteHeader(typeof(Personel));

                csv.WriteRecords(liste);

                dosya.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader dosya = new StreamReader("C:\\CSV\\personeller.csv");
            CsvReader oku = new CsvReader(dosya, CultureInfo.CurrentCulture);
            List<Personel> personeller = oku.GetRecords<Personel>().ToList();
            lst_personeller.DataSource = personeller;


        }
    }
}
