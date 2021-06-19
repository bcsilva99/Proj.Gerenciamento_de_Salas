
namespace Proj.Gerenciamento_de_Salas
{
    partial class Pag_EditarPaciente
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
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.txt_NomePaciente = new System.Windows.Forms.TextBox();
            this.txt_TelPaciente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(325, 98);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(119, 34);
            this.btn_Voltar.TabIndex = 1;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Paciente :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone do Paciente :";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(187, 98);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(119, 34);
            this.btn_Salvar.TabIndex = 8;
            this.btn_Salvar.Text = "Salvar Edição";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // txt_NomePaciente
            // 
            this.txt_NomePaciente.Location = new System.Drawing.Point(171, 12);
            this.txt_NomePaciente.Name = "txt_NomePaciente";
            this.txt_NomePaciente.Size = new System.Drawing.Size(352, 20);
            this.txt_NomePaciente.TabIndex = 9;
            // 
            // txt_TelPaciente
            // 
            this.txt_TelPaciente.Location = new System.Drawing.Point(171, 52);
            this.txt_TelPaciente.Name = "txt_TelPaciente";
            this.txt_TelPaciente.Size = new System.Drawing.Size(352, 20);
            this.txt_TelPaciente.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_TelPaciente);
            this.panel1.Controls.Add(this.btn_Voltar);
            this.panel1.Controls.Add(this.txt_NomePaciente);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 157);
            this.panel1.TabIndex = 2;
            // 
            // Pag_EditarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 259);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(685, 298);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(685, 298);
            this.Name = "Pag_EditarPaciente";
            this.ShowIcon = false;
            this.Text = "Pag_EditarPaciente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pag_EditarPaciente_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox txt_NomePaciente;
        private System.Windows.Forms.TextBox txt_TelPaciente;
        private System.Windows.Forms.Panel panel1;
    }
}