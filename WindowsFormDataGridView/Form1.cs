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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        database db = new database();
        private void Form1_Load(object sender, EventArgs e)
        {           
            List<Musteri> liste = db.musteriListele();
            dgv_musteriler.DataSource = liste;

            dgv_musteriler.Columns[0].Visible = false;
            dgv_musteriler.Columns["email"].Visible = false;

            dgv_musteriler.Columns[1].HeaderText = "AD";
            dgv_musteriler.Columns[2].HeaderText = "SOYAD";
            dgv_musteriler.Columns["Adres"].Width = 300;
        }

        private void dgv_musteriler_DoubleClick(object sender, EventArgs e)
        {
            int id =(int)dgv_musteriler[0, dgv_musteriler.CurrentCell.RowIndex].Value;

            Musteri musteri=db.musteriListele().FirstOrDefault(i => i.Id == id);

            MusteriDetay md = new MusteriDetay(musteri);
            md.ShowDialog();
        }



        private void dgv_musteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Musteri> liste = db.musteriListele();
            dgv_musteriler.DataSource = liste;
        }
    }
}
