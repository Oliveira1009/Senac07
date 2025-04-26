using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panorama.bancodedados
{
    internal class database
    {

        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=panoroma;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

    }
}
