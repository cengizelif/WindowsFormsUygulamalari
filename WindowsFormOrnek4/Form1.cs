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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ComboboxDoldur();

            // ListboxDoldur();

           
            foreach (var item in sanalDatabase.urunler)
            {
                chkList_Urunler.Items.Add(item);
            }
            
        }



        private void ListboxDoldur()
        {
            //1.yöntem
            lst_urunler.DisplayMember = "UrunAdi";//Tostring override edilmediğinde tanım yapılır
            lst_urunler.ValueMember = "ID";// arkada tutulan değer
            lst_urunler.DataSource = sanalDatabase.urunler.ToList();

            //2.yöntem
            //foreach (var item in sanalDatabase.urunler)
            //{
            //    lst_urunler.Items.Add(item);
            //}
        }

        private void ComboboxDoldur()
        {
            cmb_urunler.SelectedIndex = 0;
            cmb_urunler.DisplayMember = "UrunAdi";
            //cmb_urunler.DataSource = sanalDatabase.urunler.ToList();
            foreach (var item in sanalDatabase.urunler)
            {
                cmb_urunler.Items.Add(item);
            }
        }

        private void cmb_urunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            object nesne = cmb_urunler.SelectedItem;

            if (nesne is Urun)
            {
                Urun u1 = (Urun)nesne;

                txt_urunAd.Text = u1.UrunAdi;
                txt_kategori.Text = u1.Kategori;
                txt_stok.Text = u1.Stok.ToString();
                txt_yazar.Text = u1.Yazar;
                txt_aciklama.Text = u1.Aciklama;

                pctUrunResim.Image = Image.FromFile(u1.UrunResim);
                pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                txt_aciklama.Text = string.Empty;
                txt_kategori.Text= string.Empty;
                txt_stok.Text= string.Empty;    
                txt_urunAd.Text= string.Empty;
                txt_yazar.Text= string.Empty;
                pctUrunResim.Image = Image.FromFile("C:\\resim\\noimage.jpg");
            }


        }

        private void lst_urunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenadet = lst_urunler.SelectedItems.Count;

            if(secilenadet==1)
            {
                Urun u1 = lst_urunler.SelectedItem as Urun;

                txt_urunAd.Text = u1.UrunAdi;
                txt_kategori.Text = u1.Kategori;
                txt_stok.Text = u1.Stok.ToString();
                txt_yazar.Text = u1.Yazar;
                txt_aciklama.Text = u1.Aciklama;

                pctUrunResim.Image = Image.FromFile(u1.UrunResim);
                pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if(secilenadet>1)
            {
                List<Urun> secilenurun = new List<Urun>();

                foreach (Urun item in lst_urunler.SelectedItems)
                {
                    secilenurun.Add(item);
                }


                SecilenUrunler sf= new SecilenUrunler(secilenurun);
                sf.ShowDialog();
            }


         
        }

        private void chkList_Urunler_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue==CheckState.Checked)
            {
                Urun u =(Urun)chkList_Urunler.Items[e.Index];

                txt_urunAd.Text = u.UrunAdi;
                txt_kategori.Text = u.Kategori;
                txt_stok.Text = u.Stok.ToString();
                txt_yazar.Text =u.Yazar;
                txt_aciklama.Text = u.Aciklama;

                pctUrunResim.Image = Image.FromFile(u.UrunResim);
                pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            for (int i = 0; i < chkList_Urunler.Items.Count; i++)
            {
                if(i!=e.Index)
                {
                    chkList_Urunler.SetItemChecked(i, false);
                }
            }
        }
    }
}
