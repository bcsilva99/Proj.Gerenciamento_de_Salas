﻿using System;
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
    public partial class Pag_CadastroUsuario : Form
    {
        public Pag_CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Pag_Configuracao configuracao = new Pag_Configuracao();
            this.Hide();
            configuracao.Show();
        }

        private void Pag_CadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
