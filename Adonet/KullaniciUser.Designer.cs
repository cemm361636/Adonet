namespace Adonet
{
    partial class KullaniciYonetimi
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
            this.dgvKullaniciUser = new System.Windows.Forms.DataGridView();
            this.Kullanıcı = new System.Windows.Forms.GroupBox();
            this.Ad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciUser)).BeginInit();
            this.Kullanıcı.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKullaniciUser
            // 
            this.dgvKullaniciUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullaniciUser.Location = new System.Drawing.Point(-6, -10);
            this.dgvKullaniciUser.Name = "dgvKullaniciUser";
            this.dgvKullaniciUser.RowHeadersWidth = 51;
            this.dgvKullaniciUser.RowTemplate.Height = 24;
            this.dgvKullaniciUser.Size = new System.Drawing.Size(976, 326);
            this.dgvKullaniciUser.TabIndex = 0;
            // 
            // Kullanıcı
            // 
            this.Kullanıcı.Controls.Add(this.btnGeri);
            this.Kullanıcı.Controls.Add(this.btnSil);
            this.Kullanıcı.Controls.Add(this.btnGuncelle);
            this.Kullanıcı.Controls.Add(this.btnEkle);
            this.Kullanıcı.Controls.Add(this.TxtSifre);
            this.Kullanıcı.Controls.Add(this.label1);
            this.Kullanıcı.Controls.Add(this.txtTelefon);
            this.Kullanıcı.Controls.Add(this.txtKullaniciAdi);
            this.Kullanıcı.Controls.Add(this.txtMail);
            this.Kullanıcı.Controls.Add(this.txtSoyad);
            this.Kullanıcı.Controls.Add(this.txtAd);
            this.Kullanıcı.Controls.Add(this.label5);
            this.Kullanıcı.Controls.Add(this.label4);
            this.Kullanıcı.Controls.Add(this.label3);
            this.Kullanıcı.Controls.Add(this.label2);
            this.Kullanıcı.Controls.Add(this.Ad);
            this.Kullanıcı.Location = new System.Drawing.Point(142, 355);
            this.Kullanıcı.Name = "Kullanıcı";
            this.Kullanıcı.Size = new System.Drawing.Size(688, 277);
            this.Kullanıcı.TabIndex = 1;
            this.Kullanıcı.TabStop = false;
            this.Kullanıcı.Text = "Kullanıcı Yönetimi";
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(96, 45);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(24, 16);
            this.Ad.TabIndex = 0;
            this.Ad.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kullanıcı Adı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(210, 39);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(210, 67);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(210, 103);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 22);
            this.txtMail.TabIndex = 7;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(210, 133);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKullaniciAdi.TabIndex = 8;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(423, 136);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(100, 22);
            this.TxtSifre.TabIndex = 9;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(423, 103);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Telefon";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(124, 206);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(235, 206);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(349, 206);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(448, 206);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 15;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            // 
            // KullaniciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 701);
            this.Controls.Add(this.Kullanıcı);
            this.Controls.Add(this.dgvKullaniciUser);
            this.Name = "KullaniciYonetimi";
            this.Text = "KullaniciUser";
            this.Load += new System.EventHandler(this.KullaniciUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciUser)).EndInit();
            this.Kullanıcı.ResumeLayout(false);
            this.Kullanıcı.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullaniciUser;
        private System.Windows.Forms.GroupBox Kullanıcı;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}