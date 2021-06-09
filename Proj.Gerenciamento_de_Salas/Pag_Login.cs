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
    public partial class Pag_Login : Form
    {
        public Pag_Login()
        {
            InitializeComponent();
        }

        private void Pag_Login_Load(object sender, EventArgs e)
        {
            panelLogin.Location = new Point((this.Width / 2) - 267, (this.Height / 2) - 214);
        }        

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Pag_Menu menu = new Pag_Menu();
            this.Hide();
            menu.Show();
        }

        private void Pag_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
