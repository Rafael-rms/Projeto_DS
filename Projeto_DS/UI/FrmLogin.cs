using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_DS.DTO;
using Projeto_DS.BLL;


namespace Projeto_DS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginDTO loginDTO = new LoginDTO
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text
            };
            //Realizar a chamada do método de pesquisa do controle
            LoginBLL login = new LoginBLL();
            bool retorno = login.GetLoginBLL(loginDTO);
            //Se a variável de retorno for true exibe a mensagem de Login Ok ao usuario
            if (retorno)
            {
                //Criar um objeto que representa o formulário de menu
                FrmLogin formLogin = new FrmLogin();

                //Carregar o formulário de menu
                formLogin.Show();
                this.Hide();
            }
            else
            {
                //caso não seja possivel realizar o login exibirá a seguinte menssagem
                MessageBox.Show("Não foi possivel realizar o login, tente novamente");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
