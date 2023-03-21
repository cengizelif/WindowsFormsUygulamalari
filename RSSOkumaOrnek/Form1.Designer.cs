namespace RSSOkumaOrnek
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
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_oku = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_haber = new System.Windows.Forms.ListBox();
            this.web_haber = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_oku);
            this.groupBox1.Controls.Add(this.txt_url);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSS URL";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(15, 19);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(636, 20);
            this.txt_url.TabIndex = 0;
            this.txt_url.Text = "https://www.cnnturk.com/feed/rss/all/news";
            // 
            // btn_oku
            // 
            this.btn_oku.Location = new System.Drawing.Point(657, 17);
            this.btn_oku.Name = "btn_oku";
            this.btn_oku.Size = new System.Drawing.Size(113, 23);
            this.btn_oku.TabIndex = 1;
            this.btn_oku.Text = "XML Oku";
            this.btn_oku.UseVisualStyleBackColor = true;
            this.btn_oku.Click += new System.EventHandler(this.btn_oku_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_haber);
            this.groupBox2.Location = new System.Drawing.Point(16, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 360);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haber Başlıkları";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.web_haber);
            this.groupBox3.Location = new System.Drawing.Point(259, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 360);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Haber Detay";
            // 
            // lst_haber
            // 
            this.lst_haber.FormattingEnabled = true;
            this.lst_haber.Location = new System.Drawing.Point(11, 19);
            this.lst_haber.Name = "lst_haber";
            this.lst_haber.Size = new System.Drawing.Size(216, 329);
            this.lst_haber.TabIndex = 0;
            this.lst_haber.SelectedIndexChanged += new System.EventHandler(this.lst_haber_SelectedIndexChanged);
            // 
            // web_haber
            // 
            this.web_haber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_haber.Location = new System.Drawing.Point(3, 16);
            this.web_haber.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_haber.Name = "web_haber";
            this.web_haber.Size = new System.Drawing.Size(523, 341);
            this.web_haber.TabIndex = 0;
            this.web_haber.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_oku;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_haber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser web_haber;
    }
}

