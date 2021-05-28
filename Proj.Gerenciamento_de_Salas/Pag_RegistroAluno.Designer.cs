
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
            this.btn_BuscaAluno = new System.Windows.Forms.Button();
            this.txt_PesquisaAluno = new System.Windows.Forms.TextBox();
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
            this.ctn_CaixaDePesquisa.Location = new System.Drawing.Point(81, 36);
            this.ctn_CaixaDePesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctn_CaixaDePesquisa.Name = "ctn_CaixaDePesquisa";
            this.ctn_CaixaDePesquisa.Size = new System.Drawing.Size(644, 36);
            this.ctn_CaixaDePesquisa.TabIndex = 0;
            // 
            // btn_BuscaAluno
            // 
            this.btn_BuscaAluno.Location = new System.Drawing.Point(560, 9);
            this.btn_BuscaAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BuscaAluno.Name = "btn_BuscaAluno";
            this.btn_BuscaAluno.Size = new System.Drawing.Size(80, 23);
            this.btn_BuscaAluno.TabIndex = 1;
            this.btn_BuscaAluno.Text = "Pesquisa";
            this.btn_BuscaAluno.UseVisualStyleBackColor = true;
            this.btn_BuscaAluno.Click += new System.EventHandler(this.btn_BuscaAluno_Click);
            // 
            // txt_PesquisaAluno
            // 
            this.txt_PesquisaAluno.Location = new System.Drawing.Point(4, 7);
            this.txt_PesquisaAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PesquisaAluno.Name = "txt_PesquisaAluno";
            this.txt_PesquisaAluno.Size = new System.Drawing.Size(547, 22);
            this.txt_PesquisaAluno.TabIndex = 0;
            this.txt_PesquisaAluno.TextChanged += new System.EventHandler(this.txt_PesquisaAluno_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Nome,
            this.Col_Identificacao,
            this.Col_Contato});
            this.dataGridView1.Location = new System.Drawing.Point(81, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(859, 412);
            this.dataGridView1.TabIndex = 1;
            // 
            // Col_Nome
            // 
            this.Col_Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_Nome.FillWeight = 40F;
            this.Col_Nome.HeaderText = "Nome";
            this.Col_Nome.MinimumWidth = 6;
            this.Col_Nome.Name = "Col_Nome";
            this.Col_Nome.ReadOnly = true;
            // 
            // Col_Identificacao
            // 
            this.Col_Identificacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_Identificacao.FillWeight = 20F;
            this.Col_Identificacao.HeaderText = "Nº de Identificação";
            this.Col_Identificacao.MinimumWidth = 6;
            this.Col_Identificacao.Name = "Col_Identificacao";
            this.Col_Identificacao.ReadOnly = true;
            // 
            // Col_Contato
            // 
            this.Col_Contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_Contato.FillWeight = 40F;
            this.Col_Contato.HeaderText = "Contato";
            this.Col_Contato.MinimumWidth = 6;
            this.Col_Contato.Name = "Col_Contato";
            this.Col_Contato.ReadOnly = true;
            // 
            // btn_ExcluirAluno
            // 
            this.btn_ExcluirAluno.Location = new System.Drawing.Point(423, 511);
            this.btn_ExcluirAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ExcluirAluno.Name = "btn_ExcluirAluno";
            this.btn_ExcluirAluno.Size = new System.Drawing.Size(167, 25);
            this.btn_ExcluirAluno.TabIndex = 2;
            this.btn_ExcluirAluno.Text = "Excluir";
            this.btn_ExcluirAluno.UseVisualStyleBackColor = true;
            // 
            // btn_AdicionarAluno
            // 
            this.btn_AdicionarAluno.Location = new System.Drawing.Point(773, 511);
            this.btn_AdicionarAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AdicionarAluno.Name = "btn_AdicionarAluno";
            this.btn_AdicionarAluno.Size = new System.Drawing.Size(167, 25);
            this.btn_AdicionarAluno.TabIndex = 3;
            this.btn_AdicionarAluno.Text = "Adicionar";
            this.btn_AdicionarAluno.UseVisualStyleBackColor = true;
            // 
            // btn_EditarAluno
            // 
            this.btn_EditarAluno.Location = new System.Drawing.Point(597, 511);
            this.btn_EditarAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EditarAluno.Name = "btn_EditarAluno";
            this.btn_EditarAluno.Size = new System.Drawing.Size(167, 25);
            this.btn_EditarAluno.TabIndex = 4;
            this.btn_EditarAluno.Text = "Editar";
            this.btn_EditarAluno.UseVisualStyleBackColor = true;
            // 
            // Pag_RegistroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_EditarAluno);
            this.Controls.Add(this.btn_AdicionarAluno);
            this.Controls.Add(this.btn_ExcluirAluno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ctn_CaixaDePesquisa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pag_RegistroAluno";
            this.Text = "Pag_RegistroAluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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