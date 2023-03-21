using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSOkumaOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_oku_Click(object sender, EventArgs e)
        {
          XDocument veri=XDocument.Load(txt_url.Text);

            List<XElement> kayitlar = veri.Descendants("item").ToList();

            List<Haber> haberler=new List<Haber>();

            foreach (XElement item in kayitlar)
            {
                Haber hbr = new Haber();
                hbr.Baslik = item.Element("title").Value;
                hbr.Link=item.Element("link").Value;
                hbr.Aciklama = item.Element("description").Value;
                haberler.Add(hbr);
            }
            lst_haber.DataSource = haberler;
        }

        private void lst_haber_SelectedIndexChanged(object sender, EventArgs e)
        {
            Haber haber = (Haber)lst_haber.SelectedItem;

            web_haber.DocumentText = haber.Aciklama;
  
        }
    }
}
