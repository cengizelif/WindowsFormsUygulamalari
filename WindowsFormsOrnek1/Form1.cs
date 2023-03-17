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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txt_KullaniciAdi.Text;
            string sifre = txt_sifre.Text;

            Kullanici bulunanKullanici = sanalDatabase.kullanicilar.Find(i => i.KullanciAdi == kullaniciadi && i.Sifre == sifre);
           
            //if(sifre=="123" && kullaniciadi=="admin")
            if (bulunanKullanici!=null)
            {
                AnaForm af=new AnaForm(bulunanKullanici);
                af.ShowDialog();
               // af.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txt_KullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void txt_KullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }
    }
}
