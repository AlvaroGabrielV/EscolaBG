using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBD
{
    public static class ConexaoBD
    {
        private static readonly string conexaoString = "Server=localhost; Database=escola; UID=root; pwd=''";

        public static MySqlConnection ObterConexao()
        {
            return new MySqlConnection(conexaoString);
        }
    }
}
