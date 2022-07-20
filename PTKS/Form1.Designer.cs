namespace PTKS
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGrs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(55, 159);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(28, 13);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Sifre";
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(55, 133);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(64, 13);
            this.lblKullanıcıAdı.TabIndex = 7;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı";
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(134, 130);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(100, 20);
            this.txtKullanıcıAdı.TabIndex = 8;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(134, 156);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 10;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGrs
            // 
            this.btnGrs.Location = new System.Drawing.Point(134, 191);
            this.btnGrs.Name = "btnGrs";
            this.btnGrs.Size = new System.Drawing.Size(75, 23);
            this.btnGrs.TabIndex = 11;
            this.btnGrs.Text = "Giris";
            this.btnGrs.UseVisualStyleBackColor = true;
            this.btnGrs.Click += new System.EventHandler(this.btnGrs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 337);
            this.Controls.Add(this.btnGrs);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Controls.Add(this.lblSifre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGrs;
    }
}

