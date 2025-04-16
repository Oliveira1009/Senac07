using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Cliente.banco_de_dados
{
    internal class Database
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac";

        public static MySqlConnection GetConnection ()
        {
            return new  MySqlConnection (ConnectionString);
        }

    }
}
