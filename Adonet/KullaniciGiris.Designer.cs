namespace Adonet
{
    partial class KullaniciGiris
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
            this.btnKgGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKgKullaici = new System.Windows.Forms.TextBox();
            this.txtKgSifre = new System.Windows.Forms.TextBox();
            this.btnKgKayıtol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKgGiris
            // 
            this.btnKgGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKgGiris.Location = new System.Drawing.Point(250, 281);
            this.btnKgGiris.Name = "btnKgGiris";
            this.btnKgGiris.Size = new System.Drawing.Size(90, 35);
            this.btnKgGiris.TabIndex = 0;
            this.btnKgGiris.Text = "Giriş";
            this.btnKgGiris.UseVisualStyleBackColor = true;
            this.btnKgGiris.Click += new System.EventHandler(this.btnKgGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(202, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(247, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // txtKgKullaici
            // 
            this.txtKgKullaici.Location = new System.Drawing.Point(327, 126);
            this.txtKgKullaici.Name = "txtKgKullaici";
            this.txtKgKullaici.Size = new System.Drawing.Size(169, 22);
            this.txtKgKullaici.TabIndex = 3;
            // 
            // txtKgSifre
            // 
            this.txtKgSifre.Location = new System.Drawing.Point(327, 200);
            this.txtKgSifre.Name = "txtKgSifre";
            this.txtKgSifre.Size = new System.Drawing.Size(169, 22);
            this.txtKgSifre.TabIndex = 4;
            // 
            // btnKgKayıtol
            // 
            this.btnKgKayıtol.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKgKayıtol.Location = new System.Drawing.Point(406, 281);
            this.btnKgKayıtol.Name = "btnKgKayıtol";
            this.btnKgKayıtol.Size = new System.Drawing.Size(90, 35);
            this.btnKgKayıtol.TabIndex = 5;
            this.btnKgKayıtol.Text = "Kayıt Ol";
            this.btnKgKayıtol.UseVisualStyleBackColor = true;
            this.btnKgKayıtol.Click += new System.EventHandler(this.button2_Click);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKgKayıtol);
            this.Controls.Add(this.txtKgSifre);
            this.Controls.Add(this.txtKgKullaici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKgGiris);
            this.Name = "KullaniciGiris";
            this.Text = "Kullanıcı Giriş";
            this.Load += new System.EventHandler(this.KullaniciGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKgGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKgKullaici;
        private System.Windows.Forms.TextBox txtKgSifre;
        private System.Windows.Forms.Button btnKgKayıtol;
    }
}