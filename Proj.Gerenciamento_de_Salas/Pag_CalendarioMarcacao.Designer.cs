
namespace Proj.Gerenciamento_de_Salas
{
    partial class Pag_CalendarioMarcacao
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
            this.btn_EditarMarcacao = new System.Windows.Forms.Button();
            this.btn_EditarPaciente = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_ApagaMarcacao = new System.Windows.Forms.Button();
            this.tbl_Calendario = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_NovaMarcacao = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Segunda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terça = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quarta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quinta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sábado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Calendario)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_EditarMarcacao
            // 
            this.btn_EditarMarcacao.Location = new System.Drawing.Point(2, 60);
            this.btn_EditarMarcacao.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditarMarcacao.Name = "btn_EditarMarcacao";
            this.btn_EditarMarcacao.Size = new System.Drawing.Size(106, 38);
            this.btn_EditarMarcacao.TabIndex = 1;
            this.btn_EditarMarcacao.Text = "Editar Marcação";
            this.btn_EditarMarcacao.UseVisualStyleBackColor = true;
            this.btn_EditarMarcacao.Click += new System.EventHandler(this.btn_EditarMarcacao_Click);
            // 
            // btn_EditarPaciente
            // 
            this.btn_EditarPaciente.Location = new System.Drawing.Point(2, 118);
            this.btn_EditarPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditarPaciente.Name = "btn_EditarPaciente";
            this.btn_EditarPaciente.Size = new System.Drawing.Size(106, 38);
            this.btn_EditarPaciente.TabIndex = 2;
            this.btn_EditarPaciente.Text = "Editar Paciente";
            this.btn_EditarPaciente.UseVisualStyleBackColor = true;
            this.btn_EditarPaciente.Click += new System.EventHandler(this.btn_EditarPaciente_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(2, 234);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(106, 38);
            this.btn_Menu.TabIndex = 3;
            this.btn_Menu.Text = "Voltar para o Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_ApagaMarcacao
            // 
            this.btn_ApagaMarcacao.Location = new System.Drawing.Point(2, 176);
            this.btn_ApagaMarcacao.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ApagaMarcacao.Name = "btn_ApagaMarcacao";
            this.btn_ApagaMarcacao.Size = new System.Drawing.Size(106, 38);
            this.btn_ApagaMarcacao.TabIndex = 4;
            this.btn_ApagaMarcacao.Text = "Apagar Marcação";
            this.btn_ApagaMarcacao.UseVisualStyleBackColor = true;
            // 
            // tbl_Calendario
            // 
            this.tbl_Calendario.AllowUserToAddRows = false;
            this.tbl_Calendario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tbl_Calendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_Calendario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Segunda,
            this.Terça,
            this.Quarta,
            this.Quinta,
            this.Sexta,
            this.Sábado});
            this.tbl_Calendario.Location = new System.Drawing.Point(3, 3);
            this.tbl_Calendario.Name = "tbl_Calendario";
            this.tbl_Calendario.ReadOnly = true;
            this.tbl_Calendario.Size = new System.Drawing.Size(454, 339);
            this.tbl_Calendario.TabIndex = 5;
            this.tbl_Calendario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_NovaMarcacao, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_EditarMarcacao, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Menu, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_ApagaMarcacao, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_EditarPaciente, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(463, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(110, 290);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btn_NovaMarcacao
            // 
            this.btn_NovaMarcacao.Location = new System.Drawing.Point(2, 2);
            this.btn_NovaMarcacao.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NovaMarcacao.Name = "btn_NovaMarcacao";
            this.btn_NovaMarcacao.Size = new System.Drawing.Size(106, 38);
            this.btn_NovaMarcacao.TabIndex = 0;
            this.btn_NovaMarcacao.Text = "Nova Marcação";
            this.btn_NovaMarcacao.UseVisualStyleBackColor = true;
            this.btn_NovaMarcacao.Click += new System.EventHandler(this.btn_NovaMarcacao_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tbl_Calendario, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 346);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // Segunda
            // 
            this.Segunda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Segunda.HeaderText = "Segunda";
            this.Segunda.Name = "Segunda";
            this.Segunda.ReadOnly = true;
            // 
            // Terça
            // 
            this.Terça.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Terça.HeaderText = "Terça";
            this.Terça.Name = "Terça";
            this.Terça.ReadOnly = true;
            // 
            // Quarta
            // 
            this.Quarta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quarta.HeaderText = "Quarta";
            this.Quarta.Name = "Quarta";
            this.Quarta.ReadOnly = true;
            // 
            // Quinta
            // 
            this.Quinta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quinta.HeaderText = "Quinta";
            this.Quinta.Name = "Quinta";
            this.Quinta.ReadOnly = true;
            // 
            // Sexta
            // 
            this.Sexta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sexta.HeaderText = "Sexta";
            this.Sexta.Name = "Sexta";
            this.Sexta.ReadOnly = true;
            // 
            // Sábado
            // 
            this.Sábado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sábado.HeaderText = "Sábado";
            this.Sábado.Name = "Sábado";
            this.Sábado.ReadOnly = true;
            // 
            // Pag_CalendarioMarcacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Pag_CalendarioMarcacao";
            this.Text = "Pag_CalendarioMarcacao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pag_CalendarioMarcacao_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Calendario)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_EditarMarcacao;
        private System.Windows.Forms.Button btn_EditarPaciente;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_ApagaMarcacao;
        private System.Windows.Forms.DataGridView tbl_Calendario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_NovaMarcacao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segunda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terça;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sábado;
    }
}