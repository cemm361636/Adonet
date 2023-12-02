using System;
using System.Collections.Generic;
using System.Linq;
using System.Data; // veri tabanı işlemleri kütüphanesi
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Adonet
{
    internal class UrunDAL // Data Accces Layer : Veri erişim katmanı

    {
        SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; database =AdpnetDb; trusted_connection=true;");
        void BaglantiyiAc()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public List<Urun> UrunleriGetir()
        {
            List<Urun> urunler = new List<Urun>();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select *from Urunler", connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Urun urun = new Urun()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Description = Convert.ToString(reader["Description"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                };
                urunler.Add(urun);


            }
            reader.Close();
            sqlCommand.Dispose();
            connection.Close();
            return urunler;
        }

        public DataTable UrunleriDatatableileGetir()
        {
            DataTable table = new DataTable();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select * from Urunler", connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            table.Load(reader);
            reader.Close();
            sqlCommand.Dispose();
            table.Dispose();
            connection.Close();

            return table;
        }

        public int Add(Urun urun)
        {
            BaglantiyiAc();
            int islemSonucu = 0; // işlemsonunda db ye eklenirse geriye bu değişken üzerinden sonucu döndüreceğiz.
            SqlCommand sqlCommand = new SqlCommand("insert into Urunler(Name, Description, Price, Stock ) values (@Name, @Description, @Price, @Stock) ", connection); // komut ekleme komutlarımız
            sqlCommand.Parameters.AddWithValue("@Name", urun.Name);
            sqlCommand.Parameters.AddWithValue("@Description", urun.Description);
            sqlCommand.Parameters.AddWithValue("@Price", urun.Price);
            sqlCommand.Parameters.AddWithValue("@Stock", urun.Stock);
            islemSonucu = sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            connection.Close();
            return islemSonucu;

        }

        public int Update(Urun urun)
        {
            BaglantiyiAc();
            int islemSonucu = 0; // işlemsonunda db ye eklenirse geriye bu değişken üzerinden sonucu döndüreceğiz.
            SqlCommand sqlCommand = new SqlCommand("update Urunler set  Name = @Name, Description = @Description, Price = @Price, Stock = @Stock where Id=@UrunId ", connection); // komut ekleme komutlarımız

            sqlCommand.Parameters.AddWithValue("@UrunId", urun.Id);
            sqlCommand.Parameters.AddWithValue("@Name", urun.Name);
            sqlCommand.Parameters.AddWithValue("@Description", urun.Description);
            sqlCommand.Parameters.AddWithValue("@Price", urun.Price);
            sqlCommand.Parameters.AddWithValue("@Stock", urun.Stock);
            islemSonucu = sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            connection.Close();
            return islemSonucu;

        }

        public int Delete(int id)
        {
            BaglantiyiAc();
            int islemSonucu = 0; // işlemsonunda db ye eklenirse geriye bu değişken üzerinden sonucu döndüreceğiz.
            SqlCommand sqlCommand = new SqlCommand("delete from Urunler where Id=@UrunId ", connection); // komut ekleme komutlarımız

            sqlCommand.Parameters.AddWithValue("@UrunId", id);
            islemSonucu = sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            connection.Close();
            return islemSonucu;



        }
        public Urun UrunGetir(int id)
        {
            Urun urun = new Urun();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select * from Urunler where Id=@UrunId ", connection);
            sqlCommand.Parameters.AddWithValue("@UrunId", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                urun.Id = Convert.ToInt32(reader["Id"]);
                urun.Name = Convert.ToString(reader["Name"]);
                urun.Description = Convert.ToString(reader["Description"]);
                urun.Price = Convert.ToInt32(reader["Price"]);
                urun.Stock = Convert.ToInt32(reader["Stock"]);



            }
            reader.Close();
            sqlCommand.Dispose();
            connection.Close();
            return urun;
        }
        public DataTable UrunleriDatatableileGetir(string kelime)
        {
            DataTable table = new DataTable();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select *from Urunler where Name like @kelime", connection);
            sqlCommand.Parameters.AddWithValue("@kelime", "%" + kelime + "%");
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
