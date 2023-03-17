namespace WindowsFormOrnek4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_urunler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.pctUrunResim = new System.Windows.Forms.PictureBox();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_urunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_urunler = new System.Windows.Forms.ListBox();
            this.chkList_Urunler = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUrunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_urunler
            // 
            this.cmb_urunler.FormattingEnabled = true;
            this.cmb_urunler.Items.AddRange(new object[] {
            "Seçiniz"});
            this.cmb_urunler.Location = new System.Drawing.Point(124, 25);
            this.cmb_urunler.Name = "cmb_urunler";
            this.cmb_urunler.Size = new System.Drawing.Size(405, 21);
            this.cmb_urunler.TabIndex = 0;
            this.cmb_urunler.SelectedIndexChanged += new System.EventHandler(this.cmb_urunler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Listesi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_aciklama);
            this.groupBox1.Controls.Add(this.pctUrunResim);
            this.groupBox1.Controls.Add(this.txt_yazar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_stok);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_kategori);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_urunAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilen Ürün Detay";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(17, 183);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(488, 143);
            this.txt_aciklama.TabIndex = 3;
            // 
            // pctUrunResim
            // 
            this.pctUrunResim.Image = global::WindowsFormOrnek4.Properties.Resources.noimage;
            this.pctUrunResim.Location = new System.Drawing.Point(17, 28);
            this.pctUrunResim.Name = "pctUrunResim";
            this.pctUrunResim.Size = new System.Drawing.Size(172, 128);
            this.pctUrunResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUrunResim.TabIndex = 2;
            this.pctUrunResim.TabStop = false;
            // 
            // txt_yazar
            // 
            this.txt_yazar.Location = new System.Drawing.Point(283, 133);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(222, 23);
            this.txt_yazar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yazar";
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(283, 104);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(222, 23);
            this.txt_stok.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stok Adet";
            // 
            // txt_kategori
            // 
            this.txt_kategori.Location = new System.Drawing.Point(283, 75);
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(222, 23);
            this.txt_kategori.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategori";
            // 
            // txt_urunAd
            // 
            this.txt_urunAd.Location = new System.Drawing.Point(283, 46);
            this.txt_urunAd.Name = "txt_urunAd";
            this.txt_urunAd.Size = new System.Drawing.Size(222, 23);
            this.txt_urunAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı";
            // 
            // lst_urunler
            // 
            this.lst_urunler.FormattingEnabled = true;
            this.lst_urunler.Location = new System.Drawing.Point(707, 27);
            this.lst_urunler.Name = "lst_urunler";
            this.lst_urunler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_urunler.Size = new System.Drawing.Size(115, 368);
            this.lst_urunler.TabIndex = 3;
            this.lst_urunler.SelectedIndexChanged += new System.EventHandler(this.lst_urunler_SelectedIndexChanged);
            // 
            // chkList_Urunler
            // 
            this.chkList_Urunler.CheckOnClick = true;
            this.chkList_Urunler.FormattingEnabled = true;
            this.chkList_Urunler.Location = new System.Drawing.Point(535, 27);
            this.chkList_Urunler.Name = "chkList_Urunler";
            this.chkList_Urunler.Size = new System.Drawing.Size(166, 364);
            this.chkList_Urunler.TabIndex = 4;
            this.chkList_Urunler.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkList_Urunler_ItemCheck);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 408);
            this.Controls.Add(this.chkList_Urunler);
            this.Controls.Add(this.lst_urunler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_urunler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUrunResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_urunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctUrunResim;
        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_urunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.ListBox lst_urunler;
        private System.Windows.Forms.CheckedListBox chkList_Urunler;
    }
}

