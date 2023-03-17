namespace WindowsFormsTodoUygulamasi
{
    partial class KayitListesi
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
            this.components = new System.ComponentModel.Container();
            this.grp_islemler = new System.Windows.Forms.GroupBox();
            this.btn_ertelendi = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_beklemede = new System.Windows.Forms.Button();
            this.btn_tamamlandi = new System.Windows.Forms.Button();
            this.grp_todolist = new System.Windows.Forms.GroupBox();
            this.dgv_todolist = new System.Windows.Forms.DataGridView();
            this.todoClassBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.todoClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grp_islemler.SuspendLayout();
            this.grp_todolist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todolist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoClassBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoClassBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_islemler
            // 
            this.grp_islemler.Controls.Add(this.btn_ertelendi);
            this.grp_islemler.Controls.Add(this.btn_iptal);
            this.grp_islemler.Controls.Add(this.btn_beklemede);
            this.grp_islemler.Controls.Add(this.btn_tamamlandi);
            this.grp_islemler.Location = new System.Drawing.Point(12, 12);
            this.grp_islemler.Name = "grp_islemler";
            this.grp_islemler.Size = new System.Drawing.Size(218, 426);
            this.grp_islemler.TabIndex = 0;
            this.grp_islemler.TabStop = false;
            this.grp_islemler.Text = "İşlem Listesi";
            // 
            // btn_ertelendi
            // 
            this.btn_ertelendi.Location = new System.Drawing.Point(34, 223);
            this.btn_ertelendi.Name = "btn_ertelendi";
            this.btn_ertelendi.Size = new System.Drawing.Size(146, 49);
            this.btn_ertelendi.TabIndex = 0;
            this.btn_ertelendi.Text = "Ertelendi";
            this.btn_ertelendi.UseVisualStyleBackColor = true;
            this.btn_ertelendi.Click += new System.EventHandler(this.btn_ertelendi_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(34, 168);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(146, 49);
            this.btn_iptal.TabIndex = 0;
            this.btn_iptal.Text = "İptal Edildi";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_beklemede
            // 
            this.btn_beklemede.Location = new System.Drawing.Point(34, 113);
            this.btn_beklemede.Name = "btn_beklemede";
            this.btn_beklemede.Size = new System.Drawing.Size(146, 49);
            this.btn_beklemede.TabIndex = 0;
            this.btn_beklemede.Text = "Beklemede";
            this.btn_beklemede.UseVisualStyleBackColor = true;
            this.btn_beklemede.Click += new System.EventHandler(this.btn_beklemede_Click);
            // 
            // btn_tamamlandi
            // 
            this.btn_tamamlandi.Location = new System.Drawing.Point(34, 58);
            this.btn_tamamlandi.Name = "btn_tamamlandi";
            this.btn_tamamlandi.Size = new System.Drawing.Size(146, 49);
            this.btn_tamamlandi.TabIndex = 0;
            this.btn_tamamlandi.Text = "Tamamlandı";
            this.btn_tamamlandi.UseVisualStyleBackColor = true;
            this.btn_tamamlandi.Click += new System.EventHandler(this.btn_tamamlandi_Click);
            // 
            // grp_todolist
            // 
            this.grp_todolist.Controls.Add(this.dgv_todolist);
            this.grp_todolist.Location = new System.Drawing.Point(236, 12);
            this.grp_todolist.Name = "grp_todolist";
            this.grp_todolist.Size = new System.Drawing.Size(552, 425);
            this.grp_todolist.TabIndex = 1;
            this.grp_todolist.TabStop = false;
            this.grp_todolist.Text = "TodoList";
            // 
            // dgv_todolist
            // 
            this.dgv_todolist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_todolist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_todolist.Location = new System.Drawing.Point(3, 16);
            this.dgv_todolist.Name = "dgv_todolist";
            this.dgv_todolist.Size = new System.Drawing.Size(546, 406);
            this.dgv_todolist.TabIndex = 0;
            // 
            // todoClassBindingSource2
            // 
            this.todoClassBindingSource2.DataSource = typeof(WindowsFormsTodoUygulamasi.TodoClass);
            // 
            // todoClassBindingSource
            // 
            this.todoClassBindingSource.DataSource = typeof(WindowsFormsTodoUygulamasi.TodoClass);
            // 
            // todoClassBindingSource1
            // 
            this.todoClassBindingSource1.DataSource = typeof(WindowsFormsTodoUygulamasi.TodoClass);
            // 
            // KayitListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 445);
            this.Controls.Add(this.grp_todolist);
            this.Controls.Add(this.grp_islemler);
            this.Name = "KayitListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitListesi";
            this.Load += new System.EventHandler(this.KayitListesi_Load);
            this.grp_islemler.ResumeLayout(false);
            this.grp_todolist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todolist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoClassBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoClassBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_islemler;
        private System.Windows.Forms.Button btn_ertelendi;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_beklemede;
        private System.Windows.Forms.Button btn_tamamlandi;
        private System.Windows.Forms.GroupBox grp_todolist;
        private System.Windows.Forms.DataGridView dgv_todolist;
        private System.Windows.Forms.BindingSource todoClassBindingSource;
        private System.Windows.Forms.BindingSource todoClassBindingSource2;
        private System.Windows.Forms.BindingSource todoClassBindingSource1;
    }
}