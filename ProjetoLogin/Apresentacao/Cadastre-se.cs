using ProjetoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentacao
{
    public partial class Cadastrese : Form
    {
        public Cadastrese()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtbLogin.Text, txtbSenha.Text, txtbConfirmarSenha.Text);
            if(controle.tem)// mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(controle.mensagem); //Mensagem de erro
            }
        }
    }
}
