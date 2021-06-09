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
    public partial class Pag_Menu : Form
    {
        public Pag_Menu()
        {
            InitializeComponent();
        }

        private void btn_Calendario_Click(object sender, EventArgs e)
        {
            Pag_CalendarioMarcacao calendar = new Pag_CalendarioMarcacao();
            this.Hide();
            calendar.Show();
        }

        private void btn_RegistroAluno_Click(object sender, EventArgs e)
        {
            Pag_RegistroAluno registroAluno = new Pag_RegistroAluno();
            this.Hide();
            registroAluno.Show();
        }

        private void btn_AbreConfig_Click(object sender, EventArgs e)
        {
            Pag_Configuracao configuracao = new Pag_Configuracao();
            this.Hide();
            configuracao.Show();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Pag_Login login = new Pag_Login();
            this.Hide();
            login.Show();
        }

        private void Pag_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
