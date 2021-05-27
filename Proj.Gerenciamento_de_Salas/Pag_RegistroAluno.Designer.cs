
namespace Proj.Gerenciamento_de_Salas
{
    partial class Pag_RegistroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctn_CaixaDePesquisa = new System.Windows.Forms.Panel();
            this.txt_PesquisaAluno = new System.Windows.Forms.TextBox();
            this.btn_BuscaAluno = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Identificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ExcluirAluno = new System.Windows.Forms.Button();
            this.btn_AdicionarAluno = new System.Windows.Forms.Button();
            this.btn_EditarAluno = new System.Windows.Forms.Button();
            this.ctn_CaixaDePesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctn_CaixaDePesquisa
            // 
            this.ctn_CaixaDePesquisa.Controls.Add(this.btn_BuscaAluno);
            this.ctn_CaixaDePesquisa.Controls.Add(this.txt_PesquisaAluno);
            this.ctn_CaixaDePesquisa.Location = new System.Drawing.Point(61, 29);
            this.ctn_CaixaDePesquisa.Name = "ctn_CaixaDePesquisa";
            this.ctn_CaixaDePesquisa.Size = new System.Drawing.Size(483, 29);
            this.ctn_CaixaDePesquisa.TabIndex = 0;
            // 
            // txt_PesquisaAluno
            // 
            this.txt_PesquisaAluno.Location = new System.Drawing.Point(3, 6);
            this.txt_PesquisaAluno.Name = "txt_PesquisaAluno";
            this.txt_PesquisaAluno.Size = new System.Drawing.Size(411, 20);
            this.txt_PesquisaAluno.TabIndex = 0;
            this.txt_PesquisaAluno.TextChanged += new System.EventHandler(this.txt_PesquisaAluno_TextChanged);
            // 
            // btn_BuscaAluno
            // 
            this.btn_BuscaAluno.Location = new System.Drawing.Point(420, 7);
            this.btn_BuscaAluno.Name = "btn_BuscaAluno";
            this.btn_BuscaAluno.Size = new System.Drawing.Size(60, 19);
            this.btn_BuscaAluno.TabIndex = 1;
            this.btn_BuscaAluno.Text = "Pesquisa";
            this.btn_BuscaAluno.UseVisualStyleBackColor = true;
            this.btn_BuscaAluno.Click += new System.EventHandler(this.btn_BuscaAluno_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Nome,
            this.Col_Identificacao,
            this.Col_Contato});
            this.dataGridView1.Location = new System.Drawing.Point(61, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 335);
            this.dataGridView1.TabIndex = 1;
            // 
            // Col_Nome
            // 
            this.Col_Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_Nome.FillWeight = 40F;
            this.Col_Nome.HeaderText = "Nome";
            this.Col_Nome.Name = "Col_Nome";
            this.Col_Nome.ReadOnly = true;
            // 
            // Col_Identificacao
            // 
            this.Col_Identificacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_Identificacao.FillWeight = 20F;
            this.Col_Identificacao.HeaderText = "Nº de Identificação";
            this.Col_Identificacao.Name = "Col_Identificacao";
            this.Col_Identificacao.ReadOnly = true;
            // 
            // Col_Contato
            // 
            this.Col_Contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_Contato.FillWeight = 40F;
            this.Col_Contato.HeaderText = "Contato";
            this.Col_Contato.Name = "Col_Contato";
            this.Col_Contato.ReadOnly = true;
            // 
            // btn_ExcluirAluno
            // 
            this.btn_ExcluirAluno.Location = new System.Drawing.Point(317, 415);
            this.btn_ExcluirAluno.Name = "btn_ExcluirAluno";
            this.btn_ExcluirAluno.Size = new System.Drawing.Size(125, 20);
            this.btn_ExcluirAluno.TabIndex = 2;
            this.btn_ExcluirAluno.Text = "Excluir";
            this.btn_ExcluirAluno.UseVisualStyleBackColor = true;
            // 
            // btn_AdicionarAluno
            // 
            this.btn_AdicionarAluno.Location = new System.Drawing.Point(580, 415);
            this.btn_AdicionarAluno.Name = "btn_AdicionarAluno";
            this.btn_AdicionarAluno.Size = new System.Drawing.Size(125, 20);
            this.btn_AdicionarAluno.TabIndex = 3;
            this.btn_AdicionarAluno.Text = "Adicionar";
            this.btn_AdicionarAluno.UseVisualStyleBackColor = true;
            // 
            // btn_EditarAluno
            // 
            this.btn_EditarAluno.Location = new System.Drawing.Point(448, 415);
            this.btn_EditarAluno.Name = "btn_EditarAluno";
            this.btn_EditarAluno.Size = new System.Drawing.Size(125, 20);
            this.btn_EditarAluno.TabIndex = 4;
            this.btn_EditarAluno.Text = "Editar";
            this.btn_EditarAluno.UseVisualStyleBackColor = true;
            // 
            // Pag_RegistroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_EditarAluno);
            this.Controls.Add(this.btn_AdicionarAluno);
            this.Controls.Add(this.btn_ExcluirAluno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ctn_CaixaDePesquisa);
            this.Name = "Pag_RegistroAluno";
            this.Text = "Pag_RegistroAluno";
            this.ctn_CaixaDePesquisa.ResumeLayout(false);
            this.ctn_CaixaDePesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ctn_CaixaDePesquisa;
        private System.Windows.Forms.TextBox txt_PesquisaAluno;
        private System.Windows.Forms.Button btn_BuscaAluno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Identificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Contato;
        private System.Windows.Forms.Button btn_ExcluirAluno;
        private System.Windows.Forms.Button btn_AdicionarAluno;
        private System.Windows.Forms.Button btn_EditarAluno;
    }
}