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

namespace Dosyave_KlasörOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Personel> liste;
        private void btn_liste_Click(object sender, EventArgs e)
        {
            database db = new database();
            liste= db.PersonelGetir(100);
            lst_personel.DataSource = liste;
           
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            DirectoryInfo klasoradi;
            for (int i = 0; i < liste.Count; i++)
            {              
                if(!Directory.Exists("C:\\Personeller\\" + liste[i].ulke))
                {
                  klasoradi= Directory.CreateDirectory("C:\\Personeller\\" + liste[i].ulke);
                }
                else
                {
                    klasoradi = new DirectoryInfo("C:\\Personeller\\" + liste[i].ulke);
                }

                File.Create(klasoradi.FullName + "\\" + liste[i].isim +"."+ liste[i].soyisim + ".txt");

            }   
        }
    }
}
