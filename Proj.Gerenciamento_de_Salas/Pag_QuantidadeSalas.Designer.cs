
namespace Proj.Gerenciamento_de_Salas
{
    partial class Pag_QuantidadeSalas
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
            this.dataGridSalas = new System.Windows.Forms.DataGridView();
            this.n_Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editarsala = new System.Windows.Forms.Button();
            this.btn_adicionarsala = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.tableLayoutBotoes = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalas)).BeginInit();
            this.tableLayoutBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSalas
            // 
            this.dataGridSalas.AllowUserToAddRows = false;
            this.dataGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_Sala,
            this.Tipo_Sala});
            this.dataGridSalas.Location = new System.Drawing.Point(9, 54);
            this.dataGridSalas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridSalas.Name = "dataGridSalas";
            this.dataGridSalas.ReadOnly = true;
            this.dataGridSalas.RowHeadersWidth = 51;
            this.dataGridSalas.RowTemplate.Height = 24;
            this.dataGridSalas.Size = new System.Drawing.Size(582, 241);
            this.dataGridSalas.TabIndex = 0;
            // 
            // n_Sala
            // 
            this.n_Sala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.n_Sala.HeaderText = "Nº sala";
            this.n_Sala.MinimumWidth = 6;
            this.n_Sala.Name = "n_Sala";
            this.n_Sala.ReadOnly = true;
            // 
            // Tipo_Sala
            // 
            this.Tipo_Sala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo_Sala.HeaderText = "Tipo da sala";
            this.Tipo_Sala.MinimumWidth = 6;
            this.Tipo_Sala.Name = "Tipo_Sala";
            this.Tipo_Sala.ReadOnly = true;
            this.Tipo_Sala.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_editarsala
            // 
            this.btn_editarsala.Location = new System.Drawing.Point(2, 2);
            this.btn_editarsala.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editarsala.Name = "btn_editarsala";
            this.btn_editarsala.Size = new System.Drawing.Size(106, 30);
            this.btn_editarsala.TabIndex = 1;
            this.btn_editarsala.Text = "Editar Sala";
            this.btn_editarsala.UseVisualStyleBackColor = true;
            this.btn_editarsala.Click += new System.EventHandler(this.btn_editarsala_Click);
            // 
            // btn_adicionarsala
            // 
            this.btn_adicionarsala.Location = new System.Drawing.Point(112, 2);
            this.btn_adicionarsala.Margin = new System.Windows.Forms.Padding(2);
            this.btn_adicionarsala.Name = "btn_adicionarsala";
            this.btn_adicionarsala.Size = new System.Drawing.Size(106, 30);
            this.btn_adicionarsala.TabIndex = 2;
            this.btn_adicionarsala.Text = "Adicionar Sala";
            this.btn_adicionarsala.UseVisualStyleBackColor = true;
            this.btn_adicionarsala.Click += new System.EventHandler(this.btn_adicionarsala_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(642, 12);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(119, 22);
            this.btn_Voltar.TabIndex = 3;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // tableLayoutBotoes
            // 
            this.tableLayoutBotoes.ColumnCount = 2;
            this.tableLayoutBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutBotoes.Controls.Add(this.btn_editarsala, 0, 0);
            this.tableLayoutBotoes.Controls.Add(this.btn_adicionarsala, 1, 0);
            this.tableLayoutBotoes.Location = new System.Drawing.Point(541, 417);
            this.tableLayoutBotoes.Name = "tableLayoutBotoes";
            this.tableLayoutBotoes.RowCount = 1;
            this.tableLayoutBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutBotoes.Size = new System.Drawing.Size(220, 34);
            this.tableLayoutBotoes.TabIndex = 4;
            // 
            // Pag_QuantidadeSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 472);
            this.Controls.Add(this.tableLayoutBotoes);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.dataGridSalas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Pag_QuantidadeSalas";
            this.Text = "Pag_QuantidadeSalas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pag_QuantidadeSalas_FormClosing);
            this.Load += new System.EventHandler(this.Pag_QuantidadeSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalas)).EndInit();
            this.tableLayoutBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSalas;
        private System.Windows.Forms.Button btn_editarsala;
        private System.Windows.Forms.Button btn_adicionarsala;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Sala;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBotoes;
    }
}