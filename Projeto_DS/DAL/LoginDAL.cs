using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Projeto_DS.DTO;

namespace Projeto_DS.DAL
{
    // Verificar o login no banco de dados
    class LoginDAL
    {
        public bool GetLoginDAL(LoginDTO loginDTO)
        {
           try
            {
                MySqlConnection conn = UtilsDAL.GetConnection();

                if (conn.State == ConnectionState.Open)
                {
                    // pesquisa se o usuario existe no banco
                    string sql =    $"SELECT + FROM usuarios" +
                                    $"WHERE" +
                                    $"email = '{loginDTO.Email}'" +
                                    $"AND" +
                                    $"senha = '{loginDTO.Senha}'";
                    MySqlCommand retorno = new MySqlCommand(sql, conn);
                    //executar no banco a query
                    MySqlDataReader reader = retorno.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                    }
                }
            }
            catch (System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return false;
        }
    }
}
