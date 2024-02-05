namespace WindowsFormsApp2
{
    partial class For
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
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnSekil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSayi3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(65, 45);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(34, 13);
            this.lblSayi1.TabIndex = 0;
            this.lblSayi1.Text = "sayı1:";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(147, 45);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(37, 160);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(230, 35);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(65, 81);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(34, 13);
            this.lblSayi2.TabIndex = 3;
            this.lblSayi2.Text = "sayı2:";
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(147, 81);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 4;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(34, 218);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(39, 13);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "sonuç:";
            // 
            // btnSekil
            // 
            this.btnSekil.Location = new System.Drawing.Point(302, 43);
            this.btnSekil.Name = "btnSekil";
            this.btnSekil.Size = new System.Drawing.Size(75, 35);
            this.btnSekil.TabIndex = 6;
            this.btnSekil.Text = "şekil";
            this.btnSekil.UseVisualStyleBackColor = true;
            this.btnSekil.Click += new System.EventHandler(this.btnSekil_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lblSayi3
            // 
            this.lblSayi3.AutoSize = true;
            this.lblSayi3.Location = new System.Drawing.Point(65, 119);
            this.lblSayi3.Name = "lblSayi3";
            this.lblSayi3.Size = new System.Drawing.Size(34, 13);
            this.lblSayi3.TabIndex = 7;
            this.lblSayi3.Text = "sayı3:";
            // 
            // For
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 267);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSayi3);
            this.Controls.Add(this.btnSekil);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.lblSayi1);
            this.Name = "For";
            this.Text = " ";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnSekil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSayi3;
    }
}

