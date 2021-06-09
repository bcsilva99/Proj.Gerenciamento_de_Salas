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

        private void btn_AdicionarAluno_Click(object sender, EventArgs e)
        {
            Pag_AdicionarAluno adicionarAluno = new Pag_AdicionarAluno();            
            this.Enabled = false;
            adicionarAluno.Show(); 
        }

        private void btn_EditarAluno_Click(object sender, EventArgs e)
        {
            String nome = txt_PesquisaAluno.Text;
            Pag_AdicionarAluno editaAluno = new Pag_AdicionarAluno(nome);
            this.Enabled = false;
            editaAluno.Show();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Pag_Menu menu = new Pag_Menu();
            this.Hide();
            menu.Show();
        }

        private void Pag_RegistroAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Pag_RegistroAluno_Load(object sender, EventArgs e)
        {
            tblL_botões.Location = new Point(this.Width * 60 / 100, this.Height * 80 / 100);       
            Grid_RegistroAluno.Size = new Size(this.Width * 90/100, this.Height * 70/100);
            btn_Menu.Location = new Point(this.Width * 80 / 100, 30);

        }
    }
}
