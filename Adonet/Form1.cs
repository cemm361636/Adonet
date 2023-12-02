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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        UrunDAL urunDAL = new UrunDAL(); 

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = urunDAL.UrunleriDatatableileGetir();
           
            dgvUrunler.Columns[0].HeaderText = "Ürün No ";
            dgvUrunler.Columns[1].HeaderText = "Ürün Adı ";
            dgvUrunler.Columns[2].HeaderText = "Açıklama ";
            dgvUrunler.Columns[3].HeaderText = "Fiyat ";
            dgvUrunler.Columns[4].HeaderText = "Stok ";
        }
        void Temizle ()
        {
            txtStok.Text = string.Empty;
            txtUrunAciklaması.Text = string.Empty;
            txtUrunAdi.Text = string.Empty;
            txtUrunFiyatı.Text = string.Empty;  
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            
        }

        private void btnEkle_Click(object sender, EventArgs e)

        {
            try
            {
                var sonuc = urunDAL.Add(new Urun
                {
                    Name = txtUrunAdi.Text,
                    Description = txtUrunAciklaması.Text,
                    Price = Convert.ToDecimal(txtUrunFiyatı.Text),
                    Stock = int.Parse(txtStok.Text)

                });
                if (sonuc > 0)

                {
                    Temizle();
                    dgvUrunler.DataSource = urunDAL.UrunleriDatatableileGetir();
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

        private void txtUrunFiyatı_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = urunDAL.Update(new Urun
                {
                    Id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value),
                    Name = txtUrunAdi.Text,
                    Description = txtUrunAciklaması.Text,
                    Price = Convert.ToDecimal(txtUrunFiyatı.Text),
                    Stock = int.Parse(txtStok.Text)

                });
                if (sonuc > 0)
                {
                    Temizle();
                    dgvUrunler.DataSource = urunDAL.UrunleriDatatableileGetir();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                    MessageBox.Show("Kayıt Başarısız!");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                // ekranda ki gridview dan satır seçerek formu doldurma

              
                btnEkle.Enabled = false;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
                btnGeri.Enabled = true;
                /* txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
               txtUrunAciklaması.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
               txtUrunFiyatı.Text = dgvUrunler.CurrentRow.Cells[3].Value.ToString();
               txtStok.Text = dgvUrunler.CurrentRow.Cells[4].Value.ToString();
            */

                int urunId = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value);
                var urun = urunDAL.UrunGetir(urunId);
                txtUrunAdi.Text = urun.Name;
                txtUrunAciklaması.Text = urun.Description;
                txtUrunFiyatı.Text = urun.Price.ToString();
                txtStok.Text = urun.Stock.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int urunId = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value);
                var sonuc = urunDAL.Delete(urunId);
                if (sonuc > 0)
                {
                    Temizle();
                    dgvUrunler.DataSource = urunDAL.UrunleriDatatableileGetir();
                    MessageBox.Show("Silme Başarılı!");
                }
                else
                    MessageBox.Show("Silme Başarısız!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");

            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Temizle();

            btnGeri.Enabled = false;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = urunDAL.UrunleriDatatableileGetir(txtAra.Text);
        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
