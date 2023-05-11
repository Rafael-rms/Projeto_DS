using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Projeto_DS.DAL
{
    class UtilsDAL
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "cad_usuarios",
                UserID = "root",
                Password = ""
            };

            // Criar conexão
            MySqlConnection conection = new MySqlConnection(builder.ConnectionString);
            conection.Open();

            return conection;
        }
    }
}
