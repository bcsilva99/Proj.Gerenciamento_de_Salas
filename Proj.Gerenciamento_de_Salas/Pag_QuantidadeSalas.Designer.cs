﻿
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.n_Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editarsala = new System.Windows.Forms.Button();
            this.btn_adicionarsala = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_Sala,
            this.Tipo_Sala});
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // n_Sala
            // 
            this.n_Sala.HeaderText = "Nº sala";
            this.n_Sala.MinimumWidth = 6;
            this.n_Sala.Name = "n_Sala";
            this.n_Sala.Width = 125;
            // 
            // Tipo_Sala
            // 
            this.Tipo_Sala.HeaderText = "Tipo da sala";
            this.Tipo_Sala.MinimumWidth = 6;
            this.Tipo_Sala.Name = "Tipo_Sala";
            this.Tipo_Sala.Width = 125;
            // 
            // btn_editarsala
            // 
            this.btn_editarsala.Location = new System.Drawing.Point(710, 393);
            this.btn_editarsala.Name = "btn_editarsala";
            this.btn_editarsala.Size = new System.Drawing.Size(152, 23);
            this.btn_editarsala.TabIndex = 1;
            this.btn_editarsala.Text = "Editar Sala";
            this.btn_editarsala.UseVisualStyleBackColor = true;
            // 
            // btn_adicionarsala
            // 
            this.btn_adicionarsala.Location = new System.Drawing.Point(896, 393);
            this.btn_adicionarsala.Name = "btn_adicionarsala";
            this.btn_adicionarsala.Size = new System.Drawing.Size(119, 23);
            this.btn_adicionarsala.TabIndex = 2;
            this.btn_adicionarsala.Text = "Adicionar Sala";
            this.btn_adicionarsala.UseVisualStyleBackColor = true;
            // 
            // Pag_QuantidadeSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 581);
            this.Controls.Add(this.btn_adicionarsala);
            this.Controls.Add(this.btn_editarsala);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pag_QuantidadeSalas";
            this.Text = "Pag_QuantidadeSalas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Sala;
        private System.Windows.Forms.Button btn_editarsala;
        private System.Windows.Forms.Button btn_adicionarsala;
    }
}