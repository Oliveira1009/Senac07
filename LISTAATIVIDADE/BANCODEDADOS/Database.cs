using MySql.Data.MySqlClient;

namespace LISTAATIVIDADE.BANCODEDADOS
{
    internal class Database
    {
        private static readonly string ConnectionString = "datasourse=localhost;username=root;passaword=;database=secac;";

        public static MySqlConnection GetConnectin()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}

