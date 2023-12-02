using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet
{
    internal class OrtakDal
    {

        public SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; database =AdpnetDb; trusted_connection=true;");
        public void BaglantiyiAc()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public DataTable KayıtlarDatatableileGetir(string SqlSorgu)
        {
            DataTable table = new DataTable();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand(SqlSorgu, connection);
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
