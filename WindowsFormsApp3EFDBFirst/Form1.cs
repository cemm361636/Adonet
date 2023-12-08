using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3EFDBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AdpnetDbEntities context = new AdpnetDbEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvStokKontrol.DataSource = context.StokKontrol.ToList();

        }
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
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün Adı Boş Bırakılamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFiyat.Text))
            {
                MessageBox.Show("Ürün Fiyatı Boş Bırakılamaz!");
                return;
            }
                try
            {
                context.StokKontrol.Add(new StokKontrol
                {
                    Name = txtUrunAdi.Text,
                    Barcode = txtBarkod.Text,
                    Stock = int.Parse(txtStok.Text),
                    Price = Convert.ToInt32(txtFiyat.Text),
                    Description = txtAciklama.Text,
                    IsActive = cbDurum.Checked
                    
                }); 
                var sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    Temizle();
                    dgvStokKontrol.DataSource = context.StokKontrol.ToList();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                    MessageBox.Show("Kayıt Başarısız!");


            }
            catch (Exception Hata)
            {

                MessageBox.Show("Hata Oluştu!" + Hata);
            }

        }

        private void dgvStokKontrol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {

                btnEkle.Enabled = false;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
                btnGeri.Enabled = true;
                
                int StokId= Convert.ToInt32(dgvStokKontrol.CurrentRow.Cells[0].Value);
                var stok = context.StokKontrol.Find(StokId);
                txtUrunAdi.Text = stok.Name;
                txtBarkod.Text = stok.Barcode.ToString();
                txtStok.Text = stok.Stock.ToString();
                txtFiyat.Text = stok.Price.ToString();
                txtAciklama.Text = stok.Description;
               
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int StokId = Convert.ToInt32(dgvStokKontrol.CurrentRow.Cells[0].Value);
            var stok = context.StokKontrol.Find(StokId);
            stok.Name = txtUrunAdi.Text;
            stok.Barcode = txtBarkod.Text;
            stok.Stock = int.Parse(txtStok.Text);
            stok.Price = Convert.ToInt32(txtFiyat.Text);
            stok.Description = txtAciklama.Text;
            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                Temizle();
                dgvStokKontrol.DataSource = context.StokKontrol.ToList();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!");
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int StokId = Convert.ToInt32(dgvStokKontrol.CurrentRow.Cells[0].Value);
                var stok = context.StokKontrol.Find(StokId);
                context.StokKontrol.Remove(stok); // ef de silinecek olarak işaretler
                var sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    Temizle();
                    dgvStokKontrol.DataSource = context.StokKontrol.ToList();
                    MessageBox.Show("Kayıt Silindi!");
                }
                else
                {
                    MessageBox.Show("Kayıt Silinemedi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvStokKontrol.DataSource = context.Urunler.Where(u => u.Name.Contains(txtAra.Text)).ToList(); 
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
           
            dgvStokKontrol.DataSource = context.Urunler.Where(u => u.Name.Contains(txtAra.Text) || u.Description.Contains(txtAra.Text)).ToList();
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    
}
