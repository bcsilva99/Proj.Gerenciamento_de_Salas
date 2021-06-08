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
    public partial class Pag_NovaMarcacao : Form
    {
        public Pag_NovaMarcacao()
        {
            InitializeComponent();
        }

        public Pag_NovaMarcacao(String chaveBusca)
        {
            InitializeComponent();
            
        }


        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Pag_CalendarioMarcacao calendarioMarcacao = new Pag_CalendarioMarcacao();
            this.Hide();
            calendarioMarcacao.Show();
        }

        private void Pag_NovaMarcacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
