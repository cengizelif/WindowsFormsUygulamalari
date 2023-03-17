using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormOrnek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Uret_Click(object sender, EventArgs e)
        {
            int m1, m2, m3, m4, m5;

            Random rnd=new Random();

            m1 = rnd.Next(1,10);
            m2 = rnd.Next(11,20);  
            m3 = rnd.Next(21,30);    
            m4 = rnd.Next(31,40);
            m5 = rnd.Next(41, 50);

            flowLayoutPanel1.Enabled = true;
            flowLayoutPanel1.Controls.Clear();
            
            for (int i = 1; i < 51; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i;
                btn.Size= new System.Drawing.Size(40, 40);
                btn.Text= i.ToString(); 
                btn.UseVisualStyleBackColor = true;
               
                if(i==m1 || i==m2 || i==m3 || i==m4 || i==m5)
                {
                    btn.Tag = true;
                }
                else
                {
                    btn.Tag = false;
                }

                btn.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            bool mayin =(bool)btn.Tag;
            int skor = int.Parse(lbl_skor.Text);
            if (mayin)
            {
                btn.BackColor = Color.Red;
               DialogResult cvp= MessageBox.Show("Oyun Bitti. Tekrar oynamak ister misiniz?", "OyunSonu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(cvp==DialogResult.Yes)
                {
                    lbl_skor.Text = "0";
                    flowLayoutPanel1.Enabled = false;
                }
                else
                {
                    Close();
                }
            }
            else
            {
                btn.BackColor = Color.Green;         
                skor++;
                lbl_skor.Text=skor.ToString();
            }
           
        }
    }
}
