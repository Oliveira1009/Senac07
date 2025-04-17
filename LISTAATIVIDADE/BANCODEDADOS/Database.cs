using MySql.Data.MySqlClient;

namespace LISTAATIVIDADE.BANCODEDADOS
{
    internal class Database
    {
        private static readonly string ConnectionString = "datasource=localhost;port=3307;username=root;password=;database=lion;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}

