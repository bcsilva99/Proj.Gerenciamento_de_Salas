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
            throw new NotImplementedException();
        }
    }
}
