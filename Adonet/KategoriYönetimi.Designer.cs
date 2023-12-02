namespace Adonet
{
    partial class Kategori_Yönetimi
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
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDurum = new System.Windows.Forms.CheckBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategoriAciklamasi = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKategoriler
            // 
            this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriler.Location = new System.Drawing.Point(12, 12);
            this.dgvKategoriler.Name = "dgvKategoriler";
            this.dgvKategoriler.RowHeadersWidth = 51;
            this.dgvKategoriler.RowTemplate.Height = 24;
            this.dgvKategoriler.Size = new System.Drawing.Size(696, 552);
            this.dgvKategoriler.TabIndex = 0;
            this.dgvKategoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategoriler_CellClick);
            this.dgvKategoriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategoriler_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGeri);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDurum);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtKategoriAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKategoriAciklamasi);
            this.groupBox1.Location = new System.Drawing.Point(714, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Bilgileri";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(350, 305);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 14;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kategori Açıklaması";
            // 
            // cbDurum
            // 
            this.cbDurum.AutoSize = true;
            this.cbDurum.Location = new System.Drawing.Point(185, 255);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(54, 20);
            this.cbDurum.TabIndex = 2;
            this.cbDurum.Text = "Aktif";
            this.cbDurum.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(253, 306);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(145, 306);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(35, 306);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(185, 164);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(183, 22);
            this.txtKategoriAdi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Durum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Adı";
            // 
            // txtKategoriAciklamasi
            // 
            this.txtKategoriAciklamasi.Location = new System.Drawing.Point(185, 44);
            this.txtKategoriAciklamasi.Name = "txtKategoriAciklamasi";
            this.txtKategoriAciklamasi.Size = new System.Drawing.Size(183, 96);
            this.txtKategoriAciklamasi.TabIndex = 2;
            this.txtKategoriAciklamasi.Text = "";
            // 
            // Kategori_Yönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKategoriler);
            this.Name = "Kategori_Yönetimi";
            this.Text = "Kategori_Yonetimi";
            this.Load += new System.EventHandler(this.Kategori_Yönetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKategoriler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtKategoriAciklamasi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDurum;
        private System.Windows.Forms.Button btnGeri;
    }
}