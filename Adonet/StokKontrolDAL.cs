using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet
{
    internal class StokKontrolDAL
    {
        SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; database =AdpnetDb; trusted_connection=true;");
        void BaglantiyiAc()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public DataTable StoklarıDatatableileGetir()
        {
            DataTable table = new DataTable();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select * from StokKontrol", connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            table.Load(reader);
            reader.Close();
            sqlCommand.Dispose();
            table.Dispose();
            connection.Close();

            return table;
        }
        public int Add(StokKontrol stokKontrol)
        {
            BaglantiyiAc();
            int islemSonucu = 0;
            SqlCommand sqlCommand = new SqlCommand("insert into StokKontrol (Name, Barcode, Stock, Price, Description, IsActive ) values (@Name,@Barcode, @Stock, @Price,  @Description, @IsActive) ", connection);
            sqlCommand.Parameters.AddWithValue("@Name", stokKontrol.Name);
            sqlCommand.Parameters.AddWithValue("@Barcode", stokKontrol.Barcode);
            sqlCommand.Parameters.AddWithValue("@Stock", stokKontrol.Stock);
            sqlCommand.Parameters.AddWithValue("@Price", stokKontrol.Price);
            sqlCommand.Parameters.AddWithValue("@Description", stokKontrol.Description);
            sqlCommand.Parameters.AddWithValue("@IsActive", stokKontrol.IsActive);
            islemSonucu = sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            connection.Close();
            return islemSonucu;

        }
        public StokKontrol Get(int id)
        {
            StokKontrol stokKontrol = new StokKontrol();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select * from StokKontrol where Id=@Id ", connection);
            sqlCommand.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                stokKontrol.Id = Convert.ToInt32(reader["Id"]);
                stokKontrol.Name = Convert.ToString(reader["Name"]);
                stokKontrol.Description = Convert.ToString(reader["Description"]);
                stokKontrol.IsActive = Convert.ToBoolean(reader["IsActive"]);




            }
            reader.Close();
            sqlCommand.Dispose();
            connection.Close();
            return stokKontrol;
        }
        public int Update(StokKontrol stokKontrol)
        {

            BaglantiyiAc();
            int islemSonucu = 0; 
            SqlCommand sqlCommand = new SqlCommand("update StokKontrol set Name=@Name, Barcode=@Barcode, Stock = @Stock, Price = @Price, Description = @Description, IsActive = @IsActive where Id=@Id ", connection); 
            sqlCommand.Parameters.AddWithValue("@Name", stokKontrol.Name);
            sqlCommand.Parameters.AddWithValue("@Description", stokKontrol.Description);
            sqlCommand.Parameters.AddWithValue("@IsActive", stokKontrol.IsActive);
            sqlCommand.Parameters.AddWithValue("@Id", stokKontrol.Id);

            islemSonucu = sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            connection.Close();
            return islemSonucu;
        }
        public int Delete(int id)
        {

            BaglantiyiAc();
            int islemSonucu = 0;
            SqlCommand sqlCommand = new SqlCommand("delete from StokKontrol where Id=@Id ", connection);

            sqlCommand.Parameters.AddWithValue("@Id", id);

            islemSonucu = sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            connection.Close();
            return islemSonucu;
        }

        internal object KayıtlarıDatatableileGetir()
        {
            throw new NotImplementedException();
        }

    }
}
