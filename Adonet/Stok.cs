using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Adonet
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        StokKontrolDAL stokKontrol= new StokKontrolDAL();
        void Temizle()
        {
            txtUrunAdi.Text = string.Empty;
            txtBarkod.Text = string.Empty;
            txtStok.Text = string.Empty;
            txtFiyat.Text = string.Empty;
            txtAciklama.Text = string.Empty;




            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = stokKontrol.Add(new StokKontrol
                {
                    Name = txtUrunAdi.Text,
                    Barcode = txtBarkod.Text,
                    Stock = txtStok.Text,
                    Price = txtFiyat.Text,
                    Description = txtAciklama.Text,
                    IsActive = cbDurum.Checked


                });
                if (sonuc > 0)
                {
                    Temizle();
                    dgvStokKontrol.DataSource = stokKontrol.StoklarıDatatableileGetir();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                    MessageBox.Show("Kayıt Başarısız!");


            }
            catch (Exception Hata) 
            {

                MessageBox.Show("Hata Oluştu!"+ Hata);
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {
            dgvStokKontrol.DataSource = stokKontrol.StoklarıDatatableileGetir();
        }
      
        
        private void Stok_Load(object sender, EventArgs e)
        {
            dgvStokKontrol.DataSource = stokKontrol.StoklarıDatatableileGetir();
        }
        
        

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Temizle();

            btnGeri.Enabled = false;
        }

        private void dgvStokKontrol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = stokKontrol.Update(new StokKontrol()
                {
                    Id = Convert.ToInt32(dgvStokKontrol.CurrentRow.Cells[0].Value),
                    Name = txtUrunAdi.Text,
                    Barcode = txtBarkod.Text,
                    Stock = txtStok.Text,
                    Price = txtFiyat.Text,
                    Description = txtAciklama.Text,
                    
                        
                });
                if (sonuc > 0)
                {
                    Temizle();
                    dgvStokKontrol.DataSource = stokKontrol.StoklarıDatatableileGetir();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                    MessageBox.Show("Kayıt Başarısız!");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!");

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvStokKontrol.CurrentRow.Cells[0].Value;
                var sonuc = stokKontrol.Delete(id);
                if (sonuc > 0)

                {

                    Temizle();
                    dgvStokKontrol.DataSource = stokKontrol.StoklarıDatatableileGetir();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Silinemedi");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu!");
            }
        }
    }
}
