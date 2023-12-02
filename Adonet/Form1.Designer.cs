namespace Adonet
{
    partial class form1
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
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.btnStok = new System.Windows.Forms.Label();
            this.txtUrunFiyatı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAciklaması = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(12, 65);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.Size = new System.Drawing.Size(514, 505);
            this.dgvUrunler.TabIndex = 0;
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            this.dgvUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGeri);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtStok);
            this.groupBox1.Controls.Add(this.btnStok);
            this.groupBox1.Controls.Add(this.txtUrunFiyatı);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUrunAciklaması);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(532, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 357);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(290, 287);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 25);
            this.btnGeri.TabIndex = 11;
            this.btnGeri.Text = "Geri ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(204, 287);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 25);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(109, 287);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 25);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(15, 286);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 25);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(204, 221);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(128, 22);
            this.txtStok.TabIndex = 7;
            // 
            // btnStok
            // 
            this.btnStok.AutoSize = true;
            this.btnStok.Location = new System.Drawing.Point(116, 221);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(37, 16);
            this.btnStok.TabIndex = 6;
            this.btnStok.Text = "Stok:";
            // 
            // txtUrunFiyatı
            // 
            this.txtUrunFiyatı.Location = new System.Drawing.Point(204, 175);
            this.txtUrunFiyatı.Name = "txtUrunFiyatı";
            this.txtUrunFiyatı.Size = new System.Drawing.Size(128, 22);
            this.txtUrunFiyatı.TabIndex = 5;
            this.txtUrunFiyatı.TextChanged += new System.EventHandler(this.txtUrunFiyatı_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Fiyatı:";
            // 
            // txtUrunAciklaması
            // 
            this.txtUrunAciklaması.Location = new System.Drawing.Point(204, 62);
            this.txtUrunAciklaması.Name = "txtUrunAciklaması";
            this.txtUrunAciklaması.Size = new System.Drawing.Size(128, 96);
            this.txtUrunAciklaması.TabIndex = 3;
            this.txtUrunAciklaması.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Açıklaması:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(204, 22);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(128, 22);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ürün Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(109, 16);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 22);
            this.txtAra.TabIndex = 3;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(244, 15);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(915, 582);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUrunler);
            this.Name = "form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Yönetimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunFiyatı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtUrunAciklaması;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label btnStok;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
    }
}

