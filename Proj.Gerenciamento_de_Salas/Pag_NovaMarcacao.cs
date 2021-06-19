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

        private void Pag_NovaMarcacao_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
