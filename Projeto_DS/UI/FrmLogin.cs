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
            LoginDTO DadosLogin = new LoginDTO
            {
                Nome = txtNome.Text,
                Senha = txtSenha.Text,
            };
            LoginBLL loginBLL = new LoginBLL();
            LoginBLL.GetLoginBLL(DadosLogin);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
