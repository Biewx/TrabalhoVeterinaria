using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistema_Patas_Cuidados
{
    public class Conexao
    {
        private static string conexaoString = "server=localhost;user=root;password=;database=clinica_veterinaria";
        public static MySqlConnection ObterConexao()
        {
            return new MySqlConnection(conexaoString);
        }
    }
}

