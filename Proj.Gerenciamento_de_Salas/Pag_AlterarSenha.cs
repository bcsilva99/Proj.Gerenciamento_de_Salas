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
    public partial class Pag_AlterarSenha : Form
    {
        public Pag_AlterarSenha()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Pag_Configuracao configuracao = new Pag_Configuracao();
            this.Hide();
            configuracao.Show();
        }

        private void Pag_AlterarSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelAlterarSenha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pag_AlterarSenha_Load(object sender, EventArgs e)
        {
            panelAlterarSenha.Location = new Point((this.Width / 2) - 200, (this.Height / 2) - 165);
        }
    }
}
