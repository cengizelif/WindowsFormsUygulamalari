namespace JSONveCSVDosyalar
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
            this.btn_json_olustur = new System.Windows.Forms.Button();
            this.btn_json_oku = new System.Windows.Forms.Button();
            this.lst_personeller = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_json_olustur
            // 
            this.btn_json_olustur.Location = new System.Drawing.Point(56, 22);
            this.btn_json_olustur.Name = "btn_json_olustur";
            this.btn_json_olustur.Size = new System.Drawing.Size(115, 40);
            this.btn_json_olustur.TabIndex = 0;
            this.btn_json_olustur.Text = "JSON Dosya Oluştur";
            this.btn_json_olustur.UseVisualStyleBackColor = true;
            this.btn_json_olustur.Click += new System.EventHandler(this.btn_json_olustur_Click);
            // 
            // btn_json_oku
            // 
            this.btn_json_oku.Location = new System.Drawing.Point(200, 22);
            this.btn_json_oku.Name = "btn_json_oku";
            this.btn_json_oku.Size = new System.Drawing.Size(132, 40);
            this.btn_json_oku.TabIndex = 1;
            this.btn_json_oku.Text = "JSON Dosya Oku";
            this.btn_json_oku.UseVisualStyleBackColor = true;
            this.btn_json_oku.Click += new System.EventHandler(this.btn_json_oku_Click);
            // 
            // lst_personeller
            // 
            this.lst_personeller.FormattingEnabled = true;
            this.lst_personeller.Location = new System.Drawing.Point(25, 79);
            this.lst_personeller.Name = "lst_personeller";
            this.lst_personeller.Size = new System.Drawing.Size(375, 303);
            this.lst_personeller.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "CSV Dosya Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "CSV Dosya Oku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.lst_personeller);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_json_oku);
            this.Controls.Add(this.btn_json_olustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_json_olustur;
        private System.Windows.Forms.Button btn_json_oku;
        private System.Windows.Forms.ListBox lst_personeller;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

