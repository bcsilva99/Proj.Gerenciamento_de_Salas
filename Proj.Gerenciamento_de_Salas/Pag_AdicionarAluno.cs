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
    public partial class Pag_AdicionarAluno : Form
    {
        public Pag_AdicionarAluno()
        {
            InitializeComponent();
        }

        public Pag_AdicionarAluno(String nome)
        {
            InitializeComponent();
            PreencheDados();
        }

        private void PreencheDados()
        {
            
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Pag_RegistroAluno registroAluno = new Pag_RegistroAluno();
            this.Hide();
            registroAluno.Show();
        }

        private void Pag_AdicionarAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
