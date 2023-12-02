using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet
{
    internal class KategoriDal
    {
        SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; database =AdpnetDb; trusted_connection=true;");
        void BaglantiyiAc()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public DataTable KayıtlarDatatableileGetir()
        {
            DataTable table = new DataTable();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select * from Kategoriler", connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            table.Load(reader);
            reader.Close();
            sqlCommand.Dispose();
            table.Dispose();
            connection.Close();

            return table;

        }
        public int Add (Kategori kategori)
        {

            BaglantiyiAc();
            int islemSonucu = 0; // işlemsonunda db ye eklenirse geriye bu değişken üzerinden sonucu döndüreceğiz.
            SqlCommand sqlCommand = new SqlCommand("insert into Kategoriler(Name, Description, IsActive ) values (@Name, @Description,@IsActive) ", connection); // komut ekleme komutlarımız
            sqlCommand.Parameters.AddWithValue("@Name", kategori.Name);
            sqlCommand.Parameters.AddWithValue("@Description", kategori.Description);
            sqlCommand.Parameters.AddWithValue("@IsActive", kategori.IsActive);
            
            islemSonucu = sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            connection.Close();
            return islemSonucu;
        }
        public Kategori Get(int id)
        {
            Kategori kategori = new Kategori();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select * from Kategoriler where Id=@Id ", connection);
            sqlCommand.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                kategori.Id = Convert.ToInt32(reader["Id"]);
                kategori.Name = Convert.ToString(reader["Name"]);
                kategori.Description = Convert.ToString(reader["Description"]);
                kategori.IsActive = Convert.ToBoolean(reader["IsActive"]);         



            }
            reader.Close();
            sqlCommand.Dispose();
            connection.Close();
            return kategori;
        }


        public int Update(Kategori kategori)
        {

            BaglantiyiAc();
            int islemSonucu = 0; // işlemsonunda db ye eklenirse geriye bu değişken üzerinden sonucu döndüreceğiz.
            SqlCommand sqlCommand = new SqlCommand("update Kategoriler set Name=@Name, Description=@Description, IsActive = @IsActive where Id=@Id ", connection); // komut ekleme komutlarımız
            sqlCommand.Parameters.AddWithValue("@Name", kategori.Name);
            sqlCommand.Parameters.AddWithValue("@Description", kategori.Description);
            sqlCommand.Parameters.AddWithValue("@IsActive", kategori.IsActive);
            sqlCommand.Parameters.AddWithValue("@Id", kategori.Id);

            islemSonucu = sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            connection.Close();
            return islemSonucu;
        }

        public int Delete(int id)
        {

            BaglantiyiAc();
            int islemSonucu = 0; // işlemsonunda db ye eklenirse geriye bu değişken üzerinden sonucu döndüreceğiz.
            SqlCommand sqlCommand = new SqlCommand("delete from Kategoriler where Id=@Id ", connection); // komut ekleme komutlarımız
           
            sqlCommand.Parameters.AddWithValue("@Id", id);

            islemSonucu = sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            connection.Close();
            return islemSonucu;
        }

    }
}
