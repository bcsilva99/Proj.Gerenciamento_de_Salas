using System;
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

     

    }
}
