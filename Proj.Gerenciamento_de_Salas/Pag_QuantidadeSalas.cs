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
    public partial class Pag_QuantidadeSalas : Form
    {
        public Pag_QuantidadeSalas()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Pag_Configuracao configuracao = new Pag_Configuracao();
            this.Hide();
            configuracao.Show();
        }

        private void Pag_QuantidadeSalas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Pag_QuantidadeSalas_Load(object sender, EventArgs e)
        {
            dataGridSalas.Size = new Size(this.Width * 90 / 100, this.Height * 70 / 100);
            dataGridSalas.Location = new Point(this.Width * 5 / 100, 60);
            tableLayoutBotoes.Location = new Point(this.Width * 80 / 100, this.Height * 80 / 100);
            btn_Voltar.Location = new Point(this.Width * 85 / 100, 25);
        }

        private void btn_adicionarsala_Click(object sender, EventArgs e)
        {
            Pag_AdicionarSala adiciona = new Pag_AdicionarSala();
            this.Enabled=false;
            adiciona.Show();
        }

        private void btn_editarsala_Click(object sender, EventArgs e)
        {
            Pag_AdicionarSala adiciona = new Pag_AdicionarSala();
            this.Enabled = false;
            adiciona.Show();
        }
    }
}
