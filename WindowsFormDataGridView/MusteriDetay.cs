using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormDataGridView
{
    public partial class MusteriDetay : Form
    {
        Musteri musteridata;
        public MusteriDetay(Musteri musteri)
        {
            InitializeComponent();
            musteridata = musteri;
        }

        private void MusteriDetay_Load(object sender, EventArgs e)
        {
            txt_isim.Text = musteridata.isim;
            txt_soyisim.Text=musteridata.soyisim;   
            txt_email.Text=musteridata.email;
            txt_il.Text = musteridata.Il;
            txt_ilce.Text = musteridata.Ilce;
            txt_telefon.Text = musteridata.telefon;
            txt_adres.Text = musteridata.Adres;         

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            database db = new database();
            List<Musteri> liste = db.musteriListele();

            Musteri m=liste.FirstOrDefault(i=>i.Id==musteridata.Id);
            m.isim = txt_isim.Text;
            m.soyisim = txt_soyisim.Text;

        }
    }
}
