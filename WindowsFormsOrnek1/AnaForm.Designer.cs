namespace WindowsFormsOrnek1
{
    partial class AnaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kulAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(78, 33);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(213, 20);
            this.txt_ad.TabIndex = 0;
            this.txt_ad.Enter += new System.EventHandler(this.txt_ad_Enter);
            this.txt_ad.Leave += new System.EventHandler(this.txt_ad_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(78, 59);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(213, 20);
            this.txt_soyad.TabIndex = 1;
            this.txt_soyad.Enter += new System.EventHandler(this.txt_ad_Enter);
            this.txt_soyad.Leave += new System.EventHandler(this.txt_ad_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // txt_kulAd
            // 
            this.txt_kulAd.Location = new System.Drawing.Point(78, 85);
            this.txt_kulAd.Name = "txt_kulAd";
            this.txt_kulAd.Size = new System.Drawing.Size(213, 20);
            this.txt_kulAd.TabIndex = 2;
            this.txt_kulAd.Enter += new System.EventHandler(this.txt_ad_Enter);
            this.txt_kulAd.Leave += new System.EventHandler(this.txt_ad_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şifre";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(78, 111);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(213, 20);
            this.txt_sifre.TabIndex = 3;
            this.txt_sifre.Enter += new System.EventHandler(this.txt_ad_Enter);
            this.txt_sifre.Leave += new System.EventHandler(this.txt_ad_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Açıklama";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(78, 137);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(213, 63);
            this.txt_aciklama.TabIndex = 4;
            this.txt_aciklama.Enter += new System.EventHandler(this.txt_ad_Enter);
            this.txt_aciklama.Leave += new System.EventHandler(this.txt_ad_Leave);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(78, 206);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(103, 23);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(184, 206);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(103, 23);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 241);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_kulAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label1);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kulAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_cikis;
    }
}