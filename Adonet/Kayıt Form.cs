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
    public partial class Kayıt_Form : Form
    {
        public Kayıt_Form()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; database =AdpnetDb; trusted_connection=true;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Kullanicilar (Name, Surname, UserName, Password, Email, Phone) values(@Name, @Surname, @UserName,@Password, @Email, @Phone)";
            SqlCommand command = new SqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@Name", txtİsim.Text);
            command.Parameters.AddWithValue("@Surname", txtSoyİsim.Text);
            command.Parameters.AddWithValue("@UserName", txtKullaniciAdi.Text);
            command.Parameters.AddWithValue("@Password", txtSifre.Text);
            command.Parameters.AddWithValue("@Email", txtEmail.Text);
            command.Parameters.AddWithValue("@Phone", txtTelefon.Text);

            connection.Open();
            command.ExecuteNonQuery();


            MessageBox.Show("Kayıt Başarılı !");
            txtİsim.Clear();
            txtSoyİsim.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtEmail.Clear();
            txtTelefon.Clear();
            connection.Close();






        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kayıt_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
