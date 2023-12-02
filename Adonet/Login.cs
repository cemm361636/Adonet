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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        KullaniciDal dAl = new KullaniciDal();
        private void button1_Click(object sender, EventArgs e)
        {
            var sonuc = dAl.KullaniciGiris(txtKullaniciAdi.Text, txtSifre.Text);
           /* MessageBox.Show(sonuc.ToString());*/


            if (sonuc)
                    

            {
                groupBox1.Visible = false;
                menuStrip1.Visible = true;
                MessageBox.Show("Giriş Başarılı!");

            }
            else
            {
                MessageBox.Show("Giriş Başarısız!");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategori_Yönetimi kategori_Yönetimi = new Kategori_Yönetimi();
            kategori_Yönetimi.ShowDialog(); 
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1 form1 = new form1();
            form1.ShowDialog(); 

        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciUser = new KullaniciYonetimi();
            kullaniciUser.ShowDialog();

        }
    }
}
