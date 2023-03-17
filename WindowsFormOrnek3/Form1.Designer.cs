namespace WindowsFormOrnek3
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
            this.btn_Uret = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_skor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Uret
            // 
            this.btn_Uret.Location = new System.Drawing.Point(543, 12);
            this.btn_Uret.Name = "btn_Uret";
            this.btn_Uret.Size = new System.Drawing.Size(236, 101);
            this.btn_Uret.TabIndex = 0;
            this.btn_Uret.Text = "Üret";
            this.btn_Uret.UseVisualStyleBackColor = true;
            this.btn_Uret.Click += new System.EventHandler(this.btn_Uret_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(464, 274);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skor:";
            // 
            // lbl_skor
            // 
            this.lbl_skor.AutoSize = true;
            this.lbl_skor.Location = new System.Drawing.Point(599, 146);
            this.lbl_skor.Name = "lbl_skor";
            this.lbl_skor.Size = new System.Drawing.Size(13, 13);
            this.lbl_skor.TabIndex = 2;
            this.lbl_skor.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_skor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_Uret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Uret;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_skor;
    }
}

