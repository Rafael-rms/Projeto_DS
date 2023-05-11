using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS.DTO;
using Projeto_DS.DAL;

namespace Projeto_DS.BLL
{
    class LoginBLL
    {
        // Método de controle
        public bool GetLoginBLL(LoginDTO loginDTO)
        {
            //validar usuario
            // Realizar a chamada do método de pesquisa de login na chamda DAL
            LoginDAL login = new LoginDAL();
            bool retorno = login.GetLoginDAL(loginDTO);
            // Se o retorno do método de pesquisa da chamada DAL for verdadeiro retorna true
            if(retorno)
            {
                return true;
            }

            return false;
        }
    }
}
