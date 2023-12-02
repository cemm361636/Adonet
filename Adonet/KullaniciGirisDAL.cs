using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet
{
    internal class KullaniciGirisDAL
    {
        SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; database =AdpnetDb; trusted_connection=true;");
        void BaglantiyiAc() 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
           

        }
        public DataTable KullaniciDatatableileGetir(string Kelime)
            {
                DataTable table = new DataTable();
                BaglantiyiAc();
                SqlCommand sqlCommand = new SqlCommand("select * from Kullanici where Name Like %@Kelime%@", connection);
                sqlCommand.Parameters.AddWithValue(" %@Kelime%@", Kelime);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                table.Load(reader);
                reader.Close();
                sqlCommand.Dispose();
                table.Dispose();
                connection.Close();

                return table;
            }
    }
}
