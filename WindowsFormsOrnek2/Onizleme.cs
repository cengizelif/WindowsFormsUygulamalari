using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOrnek2
{
    public partial class Onizleme : Form
    {
        public Onizleme()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Musteri M = new Musteri()
            {
                ID = Guid.NewGuid(),
                Ad = txt_ad.Text,
                Soyad = txt_soyad.Text,
                Email = txt_email.Text,
                Telefon = txt_tel.Text
            };
            sanalDatabase.musteriler.Add(M);

            Form yakalananForm = Application.OpenForms["Form1"];

            foreach (Control item in yakalananForm.Controls)
            {
                foreach (Control item2 in item.Controls)
                {
                    if (item2 is TextBox)
                    { item2.Text = string.Empty; }
                    //MessageBox.Show(item2.Name);
                }
            }

            ((ListBox)((GroupBox)yakalananForm.Controls["groupBox2"]).Controls["lst_musteriler"]).DataSource = sanalDatabase.musteriler.ToList();

            Close();
        }
    }
}
