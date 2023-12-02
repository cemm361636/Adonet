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
    public partial class Kategori_Yönetimi : Form
    {
        public Kategori_Yönetimi()
        {
            InitializeComponent();
        }
        KategoriDal kategoriDal = new KategoriDal();
        void Temizle()
        {
            txtKategoriAciklamasi.Text = string.Empty;
            txtKategoriAdi.Text = string.Empty;

            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;

        }
        private void Kategori_Yönetimi_Load(object sender, EventArgs e)
        {

            dgvKategoriler.DataSource = kategoriDal.KayıtlarDatatableileGetir();



        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = kategoriDal.Add(new Kategori()
                {
                    Description = txtKategoriAciklamasi.Text,
                    IsActive = cbDurum.Checked,
                    Name = txtKategoriAdi.Text


                });
                if (sonuc > 0)
                {
                    Temizle();
                    dgvKategoriler.DataSource = kategoriDal.KayıtlarDatatableileGetir();
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

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
                Kategori kayit = kategoriDal.Get(Id);
                txtKategoriAciklamasi.Text = kayit.Description;
                txtKategoriAdi.Text = kayit.Name;
                cbDurum.Checked = kayit.IsActive;


                btnEkle.Enabled = false;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
                btnGeri.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = kategoriDal.Update(new Kategori()
                {
                    Id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value),
                    Description = txtKategoriAciklamasi.Text,
                    IsActive = cbDurum.Checked,
                    Name = txtKategoriAdi.Text
                });
                if (sonuc > 0)
                {
                    Temizle();
                    dgvKategoriler.DataSource = kategoriDal.KayıtlarDatatableileGetir();
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
                int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value;
                var sonuc = kategoriDal.Delete(id);
                if (sonuc > 0) 
                
                {

                    Temizle();
                    dgvKategoriler.DataSource = kategoriDal.KayıtlarDatatableileGetir();
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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Temizle();

            btnGeri.Enabled = false;
        }

        private void dgvKategoriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
