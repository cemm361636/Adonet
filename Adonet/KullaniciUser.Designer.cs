namespace Adonet
{
    partial class KullaniciUser
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKullaniciUser
            // 
            this.dgvKullaniciUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullaniciUser.Location = new System.Drawing.Point(-2, -6);
            this.dgvKullaniciUser.Name = "dgvKullaniciUser";
            this.dgvKullaniciUser.RowHeadersWidth = 51;
            this.dgvKullaniciUser.RowTemplate.Height = 24;
            this.dgvKullaniciUser.Size = new System.Drawing.Size(861, 326);
            this.dgvKullaniciUser.TabIndex = 0;
            // 
            // KullaniciUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 498);
            this.Controls.Add(this.dgvKullaniciUser);
            this.Name = "KullaniciUser";
            this.Text = "KullaniciUser";
            this.Load += new System.EventHandler(this.KullaniciUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullaniciUser;
    }
}