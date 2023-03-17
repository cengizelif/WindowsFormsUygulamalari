using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOrnek1
{
    public partial class AnaForm : Form
    {
        public AnaForm(Kullanici bulunanKullanici)
        {
            InitializeComponent();
            txt_ad.Text = bulunanKullanici.Ad;
            txt_soyad.Text= bulunanKullanici.Soyad;
            txt_kulAd.Text = bulunanKullanici.KullanciAdi;
            txt_sifre.Text = bulunanKullanici.Sifre;
            txt_aciklama.Text = bulunanKullanici.Aciklama;
            btn_guncelle.Tag = bulunanKullanici.ID;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id =(int)btn_guncelle.Tag;
            int index = sanalDatabase.kullanicilar.FindIndex(i => i.ID == id);
            sanalDatabase.kullanicilar[index].KullanciAdi = txt_kulAd.Text;
            sanalDatabase.kullanicilar[index].Sifre = txt_sifre.Text;
            sanalDatabase.kullanicilar[index].Ad = txt_ad.Text;
            sanalDatabase.kullanicilar[index].Soyad = txt_soyad.Text;
            sanalDatabase.kullanicilar[index].Aciklama = txt_aciklama.Text;

            MessageBox.Show("Bilgileriniz güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void txt_ad_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Yellow;
        }

        private void txt_ad_Leave(object sender, EventArgs e)
        {
            TextBox t= (TextBox)sender;
            t.BackColor = Color.White;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
           DialogResult cevap=MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                Close();
            }
            else if(cevap == DialogResult.No)
            {

            }
            else if(cevap == DialogResult.Cancel) 
            { 
            
            }



        }
    }
}
