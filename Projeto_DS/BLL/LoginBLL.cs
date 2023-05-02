﻿using System;
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
        public bool GetLoginBLL(LoginDTO DadosLogin)
        {
            // Validação
            if(DadosLogin.Nome == null)
            {
                return false;
            }
            //Criar um objeto DAL
            LoginDAL login = new LoginDAL();

            // Chamar o LoginDAL
            login.GetLoginDal(DadosLogin);

            return true;
        }
    }
}
