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
    public partial class Pag_CalendarioMarcacao : Form
    {
        public Pag_CalendarioMarcacao()
        {
            InitializeComponent();
        }

        private void btn_NovaMarcacao_Click(object sender, EventArgs e)
        {
            Pag_NovaMarcacao novaMarcacao = new Pag_NovaMarcacao();
            this.Hide();
            novaMarcacao.Show();
        }

        private void btn_EditarMarcacao_Click(object sender, EventArgs e)
        {
            String chaveBusca = tbl_Calendario.SelectedRows.ToString();
            Pag_NovaMarcacao editarMarcacao = new Pag_NovaMarcacao(chaveBusca);
            this.Hide();
            editarMarcacao.Show();
        }

        private void btn_EditarPaciente_Click(object sender, EventArgs e)
        {
            Pag_EditarPaciente editarPaciente = new Pag_EditarPaciente();
            this.Hide();
            editarPaciente.Show();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Pag_Menu menu = new Pag_Menu();
            this.Hide();
            menu.Show();
        }       

        private void Pag_CalendarioMarcacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Pag_CalendarioMarcacao_Load(object sender, EventArgs e)
        {
            tblL_Calendario.Location = new Point(this.Width*5/100, this.Height*5/100);
            tblL_Calendario.Size = new Size(this.Width* 90/100, this.Height*80/100);
            tbl_Calendario.Size = new Size(tblL_Calendario.Width * 90 / 100, tblL_Calendario.Height); 
            tbL_Botoes.Size = new Size(tblL_Calendario.Width * 10 / 100, tblL_Calendario.Height/2);
            btn_ApagaMarcacao.Width = tbL_Botoes.Width;
            btn_EditarMarcacao.Width = tbL_Botoes.Width;
            btn_EditarPaciente.Width = tbL_Botoes.Width;
            btn_Menu.Width = tbL_Botoes.Width;
            btn_NovaMarcacao.Width = tbL_Botoes.Width;
        }
    }
}
