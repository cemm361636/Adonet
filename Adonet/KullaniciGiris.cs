using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;    

namespace Adonet
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; database =AdpnetDb; trusted_connection=true;");
        private void button2_Click(object sender, EventArgs e)
        {
           Kayıt_Form form =new Kayıt_Form();
            form.Show();
        }

        private void btnKgGiris_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Kullanicilar  where UserName = '" + txtKgKullaici.Text + "' and Password = '" + txtKgSifre.Text + "'", connection);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Stok form = new Stok();
                form.Show();
                txtKgKullaici.Clear();
                txtKgSifre.Clear();


            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");

            }
            connection.Close();
        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
