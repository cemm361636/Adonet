namespace Adonet
{
    partial class Stok
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
            this.dgvStokKontrol = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cbDurum = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokKontrol)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStokKontrol
            // 
            this.dgvStokKontrol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStokKontrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokKontrol.Location = new System.Drawing.Point(12, 12);
            this.dgvStokKontrol.Name = "dgvStokKontrol";
            this.dgvStokKontrol.RowHeadersWidth = 51;
            this.dgvStokKontrol.RowTemplate.Height = 24;
            this.dgvStokKontrol.Size = new System.Drawing.Size(450, 426);
            this.dgvStokKontrol.TabIndex = 0;
            this.dgvStokKontrol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStokKontrol_CellContentClick);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(242, 351);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 18;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(80, 21);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(80, 72);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(100, 22);
            this.txtBarkod.TabIndex = 4;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(80, 123);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 22);
            this.txtStok.TabIndex = 5;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(80, 174);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Barkod";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Açıklama";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(-3, 351);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(80, 351);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(161, 351);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cbDurum
            // 
            this.cbDurum.AutoSize = true;
            this.cbDurum.Location = new System.Drawing.Point(85, 322);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(54, 20);
            this.cbDurum.TabIndex = 20;
            this.cbDurum.Text = "Aktif\r\n";
            this.cbDurum.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.cbDurum);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.btnGeri);
            this.groupBox1.Controls.Add(this.txtBarkod);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.txtStok);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(478, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 389);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(85, 221);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(100, 96);
            this.txtAciklama.TabIndex = 21;
            this.txtAciklama.Text = "";
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStokKontrol);
            this.Name = "Stok";
            this.Text = "Stok Kontrol";
            this.Load += new System.EventHandler(this.Stok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokKontrol)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStokKontrol;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.CheckBox cbDurum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtAciklama;
    }
}