using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet
{
    internal class KullaniciDal : OrtakDal
    {
        internal object DatatableileGetir()
        {
            throw new NotImplementedException();
        }

        internal bool KullaniciGiris(string kullaniciAdi, string sifre)

        {
            BaglantiyiAc();
           
            SqlCommand sqlCommand = new SqlCommand("select * from Kullanicilar where UserName = @UserName and Password = @Password ", connection); // komut ekleme komutlarımız
            sqlCommand.Parameters.AddWithValue("@UserName", kullaniciAdi);
            sqlCommand.Parameters.AddWithValue("@Password", sifre);


            SqlDataReader reader = sqlCommand.ExecuteReader();

            //reader.Read();
            try
            {
                if (reader.HasRows)
                {
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                reader.Close();
                sqlCommand.Dispose();
                connection.Close();
            }
           
            return false;
        }
    }
}
