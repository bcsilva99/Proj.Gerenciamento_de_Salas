using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj.Gerenciamento_de_Salas
{
    public partial class Pag_Configuracao : Form
    {
        public Pag_Configuracao()
        {
            InitializeComponent();
        }

        private void btn_AlteraSenha_Click(object sender, EventArgs e)
        {
            Pag_AlterarSenha alterarSenha = new Pag_AlterarSenha();
            this.Enabled=false;
            alterarSenha.Show();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Pag_Menu menu = new Pag_Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_NovoUsuário_Click(object sender, EventArgs e)
        {
            Pag_CadastroUsuario cadastroUsuario = new Pag_CadastroUsuario();
            this.Enabled=false;
            cadastroUsuario.Show();
        }

        private void btn_QuantSalas_Click(object sender, EventArgs e)
        {
            Pag_QuantidadeSalas quantidadeSalas = new Pag_QuantidadeSalas();
            this.Hide();
            quantidadeSalas.Show();
        }

        private void Pag_Configuracao_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Pag_Configuracao_Load(object sender, EventArgs e)
        {
            panelConfig.Location = new Point((this.Width / 2) - 274, (this.Height / 2) - 192);
        }
    }
}
