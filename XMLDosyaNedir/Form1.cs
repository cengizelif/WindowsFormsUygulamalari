using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XMLDosyaNedir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextWriter xmlDosya = new XmlTextWriter("C:\\XML\\Personeller.xml",UTF8Encoding.UTF8);
            xmlDosya.WriteComment("XML işlemleri");
            xmlDosya.WriteStartElement("Personeller");

            xmlDosya.WriteStartElement("Personel");
            xmlDosya.WriteAttributeString("ID", "1");
            xmlDosya.WriteElementString("Isim", "Elif");
            xmlDosya.WriteElementString("Soyisim", "Cengiz");
            xmlDosya.WriteEndElement();

            xmlDosya.WriteStartElement("Personel");
            xmlDosya.WriteAttributeString("ID", "2");
            xmlDosya.WriteElementString("Isim", "xxxx");
            xmlDosya.WriteElementString("Soyisim", "xxx");
            xmlDosya.WriteEndElement();

            xmlDosya.WriteEndElement();
            xmlDosya.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlReader xmlReader = XmlReader.Create("C:\\XML\\Personeller.xml");
            while (xmlReader.Read()) 
            {
                string dugum= xmlReader.Name.ToString();
                string deger = xmlReader.Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument xmldosya = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"),
               new XElement("Personeller",
             
               new XComment("Personel bilgileri "),
             
               new XElement("Personel",new XAttribute("ID","1"),
               new XElement("Isim","Elif"),
               new XElement("Soyisim","Cengiz")
               ),
               new XElement("Personel", new XAttribute("ID", "2"),
               new XElement("Isim", "xxx"),
               new XElement("Soyisim", "xxxx")
               )
               )               
               );
            xmldosya.Save("C:\\XML\\Personeller2.xml");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Ogrenci> liste = new List<Ogrenci>();

            for (int i = 0; i < 100; i++)
            {
                Ogrenci o = new Ogrenci();
                o.Id = Guid.NewGuid();
                o.Isim = FakeData.NameData.GetFirstName();
                o.Soyisim = FakeData.NameData.GetSurname();
                o.OgrenciNo = FakeData.NumberData.GetNumber(100, 500);
                liste.Add(o);
            }

            XDocument xmldosya = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), new XElement("Ogrenciler",
              liste.Select(i=> new XElement("Ogrenci",
                               new XAttribute("ID", i.Id),
                               new XElement("Isim", i.Isim),
                               new XElement("Soyisim", i.Soyisim),
                               new XElement("Numara",i.OgrenciNo)
                           ))
                ));

            xmldosya.Save("C:\\XML\\Ogrenciler.xml");
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XDocument dosya = XDocument.Load("C:\\XML\\Ogrenciler.xml");
            List<XElement> elementlist = dosya.Descendants("Ogrenci").ToList();

            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            foreach (var item in elementlist)
            {
                Ogrenci o = new Ogrenci();
                o.Isim = item.Element("Isim").Value;
                o.Soyisim = item.Element("Soyisim").Value;
                o.OgrenciNo =int.Parse(item.Element("Numara").Value);
               
                ogrenciler.Add(o);
            }

            lst_ogrenciler.DataSource = ogrenciler;
        }
    }
}
