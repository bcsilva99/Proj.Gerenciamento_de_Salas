
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
            this.Grid_RegistroAluno = new System.Windows.Forms.DataGridView();
            this.Col_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Identificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ExcluirAluno = new System.Windows.Forms.Button();
            this.btn_AdicionarAluno = new System.Windows.Forms.Button();
            this.btn_EditarAluno = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.tblL_botões = new System.Windows.Forms.TableLayoutPanel();
            this.ctn_CaixaDePesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_RegistroAluno)).BeginInit();
            this.tblL_botões.SuspendLayout();
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
            // btn_BuscaAluno
            // 
            this.btn_BuscaAluno.Location = new System.Drawing.Point(420, 7);
            this.btn_BuscaAluno.Name = "btn_BuscaAluno";
            this.btn_BuscaAluno.Size = new System.Drawing.Size(60, 19);
            this.btn_BuscaAluno.TabIndex = 1;
            this.btn_BuscaAluno.Text = "Pesquisa";
            this.btn_BuscaAluno.UseVisualStyleBackColor = true;
            // 
            // txt_PesquisaAluno
            // 
            this.txt_PesquisaAluno.Location = new System.Drawing.Point(3, 6);
            this.txt_PesquisaAluno.Name = "txt_PesquisaAluno";
            this.txt_PesquisaAluno.Size = new System.Drawing.Size(411, 20);
            this.txt_PesquisaAluno.TabIndex = 0;
            // 
            // Grid_RegistroAluno
            // 
            this.Grid_RegistroAluno.AllowUserToAddRows = false;
            this.Grid_RegistroAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_RegistroAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Nome,
            this.Col_Identificacao,
            this.Col_Contato});
            this.Grid_RegistroAluno.Location = new System.Drawing.Point(49, 64);
            this.Grid_RegistroAluno.Name = "Grid_RegistroAluno";
            this.Grid_RegistroAluno.ReadOnly = true;
            this.Grid_RegistroAluno.RowHeadersWidth = 51;
            this.Grid_RegistroAluno.Size = new System.Drawing.Size(644, 335);
            this.Grid_RegistroAluno.TabIndex = 1;
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
            this.btn_ExcluirAluno.AutoSize = true;
            this.btn_ExcluirAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirAluno.Location = new System.Drawing.Point(3, 3);
            this.btn_ExcluirAluno.Name = "btn_ExcluirAluno";
            this.btn_ExcluirAluno.Size = new System.Drawing.Size(106, 22);
            this.btn_ExcluirAluno.TabIndex = 2;
            this.btn_ExcluirAluno.Text = "Excluir";
            this.btn_ExcluirAluno.UseVisualStyleBackColor = true;
            // 
            // btn_AdicionarAluno
            // 
            this.btn_AdicionarAluno.AutoSize = true;
            this.btn_AdicionarAluno.Location = new System.Drawing.Point(227, 3);
            this.btn_AdicionarAluno.Name = "btn_AdicionarAluno";
            this.btn_AdicionarAluno.Size = new System.Drawing.Size(108, 22);
            this.btn_AdicionarAluno.TabIndex = 3;
            this.btn_AdicionarAluno.Text = "Adicionar";
            this.btn_AdicionarAluno.UseVisualStyleBackColor = true;
            this.btn_AdicionarAluno.Click += new System.EventHandler(this.btn_AdicionarAluno_Click);
            // 
            // btn_EditarAluno
            // 
            this.btn_EditarAluno.AutoSize = true;
            this.btn_EditarAluno.Location = new System.Drawing.Point(115, 3);
            this.btn_EditarAluno.Name = "btn_EditarAluno";
            this.btn_EditarAluno.Size = new System.Drawing.Size(106, 22);
            this.btn_EditarAluno.TabIndex = 4;
            this.btn_EditarAluno.Text = "Editar Aluno";
            this.btn_EditarAluno.UseVisualStyleBackColor = true;
            this.btn_EditarAluno.Click += new System.EventHandler(this.btn_EditarAluno_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(663, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(125, 20);
            this.btn_Menu.TabIndex = 5;
            this.btn_Menu.Text = "Voltar ao Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // tblL_botões
            // 
            this.tblL_botões.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tblL_botões.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblL_botões.ColumnCount = 3;
            this.tblL_botões.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblL_botões.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblL_botões.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblL_botões.Controls.Add(this.btn_ExcluirAluno, 0, 0);
            this.tblL_botões.Controls.Add(this.btn_EditarAluno, 1, 0);
            this.tblL_botões.Controls.Add(this.btn_AdicionarAluno, 2, 0);
            this.tblL_botões.Location = new System.Drawing.Point(450, 410);
            this.tblL_botões.Name = "tblL_botões";
            this.tblL_botões.RowCount = 1;
            this.tblL_botões.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblL_botões.Size = new System.Drawing.Size(338, 28);
            this.tblL_botões.TabIndex = 6;
            // 
            // Pag_RegistroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblL_botões);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.Grid_RegistroAluno);
            this.Controls.Add(this.ctn_CaixaDePesquisa);
            this.MaximizeBox = false;
            this.Name = "Pag_RegistroAluno";
            this.Text = "Pag_RegistroAluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pag_RegistroAluno_FormClosing);
            this.Load += new System.EventHandler(this.Pag_RegistroAluno_Load);
            this.ctn_CaixaDePesquisa.ResumeLayout(false);
            this.ctn_CaixaDePesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_RegistroAluno)).EndInit();
            this.tblL_botões.ResumeLayout(false);
            this.tblL_botões.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ctn_CaixaDePesquisa;
        private System.Windows.Forms.TextBox txt_PesquisaAluno;
        private System.Windows.Forms.Button btn_BuscaAluno;
        private System.Windows.Forms.DataGridView Grid_RegistroAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Identificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Contato;
        private System.Windows.Forms.Button btn_ExcluirAluno;
        private System.Windows.Forms.Button btn_AdicionarAluno;
        private System.Windows.Forms.Button btn_EditarAluno;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.TableLayoutPanel tblL_botões;
    }
}