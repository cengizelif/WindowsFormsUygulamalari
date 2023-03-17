using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormOrnek4
{
    public partial class SecilenUrunler : Form
    {
        private List<Urun> liste;
        public SecilenUrunler(List<Urun> secilenurunler)
        {
            InitializeComponent();
            liste = secilenurunler; 
        }

        private void SecilenUrunler_Load(object sender, EventArgs e)
        {
            foreach (var item in liste)
            {
                Button btn = new Button();
                btn.Name = item.ID.ToString();
                btn.Size= new System.Drawing.Size(100,30);
                btn.Text = item.UrunAdi;
                btn.UseVisualStyleBackColor = true;
                btn.Tag = item;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b=sender as Button;
            Urun U=b.Tag as Urun;   

            Form F1 = Application.OpenForms["Form1"];
            GroupBox G1 =(GroupBox)F1.Controls["groupBox1"];
            G1.Controls["txt_urunAd"].Text = U.UrunAdi;
            G1.Controls["txt_kategori"].Text = U.Kategori;
            G1.Controls["txt_stok"].Text = U.Stok.ToString();
            G1.Controls["txt_yazar"].Text = U.Yazar;
            G1.Controls["txt_aciklama"].Text = U.Aciklama;
            ((PictureBox)G1.Controls["pctUrunResim"]).Image = Image.FromFile(U.UrunResim);
         
        }
    }
}
