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
    public partial class Pag_RegistroAluno : Form
    {
        public Pag_RegistroAluno()
        {
            InitializeComponent();
        }

        private void txt_PesquisaAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_BuscaAluno_Click(object sender, EventArgs e)
        {

        }

        private void btn_AdicionarAluno_Click(object sender, EventArgs e)
        {
            Pag_AdicionarAluno adicionarAluno = new Pag_AdicionarAluno();
            this.Hide();
            adicionarAluno.Show();
        }

        private void btn_EditarAluno_Click(object sender, EventArgs e)
        {
            String nome = txt_PesquisaAluno.Text;
            Pag_AdicionarAluno editaAluno = new Pag_AdicionarAluno(nome);
            this.Hide();
            editaAluno.Show();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Pag_Menu menu = new Pag_Menu();
            this.Hide();
            menu.Show();
        }
    }
}
