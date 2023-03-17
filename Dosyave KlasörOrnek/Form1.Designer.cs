namespace Dosyave_KlasörOrnek
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_personel = new System.Windows.Forms.ListBox();
            this.btn_liste = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.btn_liste);
            this.groupBox1.Controls.Add(this.lst_personel);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Listesi";
            // 
            // lst_personel
            // 
            this.lst_personel.FormattingEnabled = true;
            this.lst_personel.Location = new System.Drawing.Point(13, 19);
            this.lst_personel.Name = "lst_personel";
            this.lst_personel.Size = new System.Drawing.Size(177, 290);
            this.lst_personel.TabIndex = 0;
            // 
            // btn_liste
            // 
            this.btn_liste.Location = new System.Drawing.Point(13, 331);
            this.btn_liste.Name = "btn_liste";
            this.btn_liste.Size = new System.Drawing.Size(177, 33);
            this.btn_liste.TabIndex = 1;
            this.btn_liste.Text = "Personel Getir";
            this.btn_liste.UseVisualStyleBackColor = true;
            this.btn_liste.Click += new System.EventHandler(this.btn_liste_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(13, 370);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(177, 33);
            this.btn_kaydet.TabIndex = 1;
            this.btn_kaydet.Text = "Personel Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 462);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_liste;
        private System.Windows.Forms.ListBox lst_personel;
    }
}

