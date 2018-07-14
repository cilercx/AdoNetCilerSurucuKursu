namespace CilerSurucuKursuForm
{
    partial class GenelEkran
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
            this.btnMusIslemleri = new System.Windows.Forms.Button();
            this.btnKulIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusIslemleri
            // 
            this.btnMusIslemleri.Location = new System.Drawing.Point(44, 42);
            this.btnMusIslemleri.Name = "btnMusIslemleri";
            this.btnMusIslemleri.Size = new System.Drawing.Size(103, 48);
            this.btnMusIslemleri.TabIndex = 0;
            this.btnMusIslemleri.Text = "Musteri İşlemleri";
            this.btnMusIslemleri.UseVisualStyleBackColor = true;
            this.btnMusIslemleri.Click += new System.EventHandler(this.btnMusIslemleri_Click);
            // 
            // btnKulIslemleri
            // 
            this.btnKulIslemleri.Location = new System.Drawing.Point(191, 42);
            this.btnKulIslemleri.Name = "btnKulIslemleri";
            this.btnKulIslemleri.Size = new System.Drawing.Size(107, 48);
            this.btnKulIslemleri.TabIndex = 1;
            this.btnKulIslemleri.Text = "Kullanici Işlemleri";
            this.btnKulIslemleri.UseVisualStyleBackColor = true;
            this.btnKulIslemleri.Click += new System.EventHandler(this.btnKulIslemleri_Click);
            // 
            // GenelEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 159);
            this.Controls.Add(this.btnKulIslemleri);
            this.Controls.Add(this.btnMusIslemleri);
            this.Name = "GenelEkran";
            this.Text = "GenelEkran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusIslemleri;
        private System.Windows.Forms.Button btnKulIslemleri;
    }
}