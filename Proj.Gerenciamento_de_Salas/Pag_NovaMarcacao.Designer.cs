
namespace Proj.Gerenciamento_de_Salas
{
    partial class Pag_NovaMarcacao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSala = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TelPaciente = new System.Windows.Forms.TextBox();
            this.txt_NomePaciente = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.comboBoxAluno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxHorario = new System.Windows.Forms.ComboBox();
            this.dateTimePrimeiraConsulta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(740, 364);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(159, 42);
            this.btn_Voltar.TabIndex = 0;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxSala);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_TelPaciente);
            this.panel1.Controls.Add(this.txt_NomePaciente);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.comboBoxAluno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxHorario);
            this.panel1.Controls.Add(this.dateTimePrimeiraConsulta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Voltar);
            this.panel1.Location = new System.Drawing.Point(79, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 423);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sala :";
            // 
            // comboBoxSala
            // 
            this.comboBoxSala.FormattingEnabled = true;
            this.comboBoxSala.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "20",
            "22",
            "27"});
            this.comboBoxSala.Location = new System.Drawing.Point(228, 246);
            this.comboBoxSala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSala.Name = "comboBoxSala";
            this.comboBoxSala.Size = new System.Drawing.Size(363, 24);
            this.comboBoxSala.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Horário :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data da Primeira Consulta :";
            // 
            // txt_TelPaciente
            // 
            this.txt_TelPaciente.Location = new System.Drawing.Point(228, 64);
            this.txt_TelPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TelPaciente.Name = "txt_TelPaciente";
            this.txt_TelPaciente.Size = new System.Drawing.Size(363, 22);
            this.txt_TelPaciente.TabIndex = 10;
            // 
            // txt_NomePaciente
            // 
            this.txt_NomePaciente.Location = new System.Drawing.Point(228, 15);
            this.txt_NomePaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NomePaciente.Name = "txt_NomePaciente";
            this.txt_NomePaciente.Size = new System.Drawing.Size(363, 22);
            this.txt_NomePaciente.TabIndex = 9;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(552, 364);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(159, 42);
            this.btn_Salvar.TabIndex = 8;
            this.btn_Salvar.Text = "Salvar Marcação";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // comboBoxAluno
            // 
            this.comboBoxAluno.FormattingEnabled = true;
            this.comboBoxAluno.Items.AddRange(new object[] {
            "Arthur",
            "Bruna",
            "Bruno",
            "Carlos",
            "Gabriela",
            "Thyago"});
            this.comboBoxAluno.Location = new System.Drawing.Point(228, 185);
            this.comboBoxAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxAluno.Name = "comboBoxAluno";
            this.comboBoxAluno.Size = new System.Drawing.Size(363, 24);
            this.comboBoxAluno.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aluno :";
            // 
            // comboBoxHorario
            // 
            this.comboBoxHorario.FormattingEnabled = true;
            this.comboBoxHorario.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.comboBoxHorario.Location = new System.Drawing.Point(701, 121);
            this.comboBoxHorario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxHorario.Name = "comboBoxHorario";
            this.comboBoxHorario.Size = new System.Drawing.Size(160, 24);
            this.comboBoxHorario.TabIndex = 5;
            // 
            // dateTimePrimeiraConsulta
            // 
            this.dateTimePrimeiraConsulta.Location = new System.Drawing.Point(228, 121);
            this.dateTimePrimeiraConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePrimeiraConsulta.Name = "dateTimePrimeiraConsulta";
            this.dateTimePrimeiraConsulta.Size = new System.Drawing.Size(363, 22);
            this.dateTimePrimeiraConsulta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone do Paciente :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Paciente :";
            // 
            // Pag_NovaMarcacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1082, 591);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "Pag_NovaMarcacao";
            this.ShowIcon = false;
            this.Text = "Pag_NovaMarcacao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pag_NovaMarcacao_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePrimeiraConsulta;
        private System.Windows.Forms.ComboBox comboBoxHorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAluno;
        private System.Windows.Forms.TextBox txt_TelPaciente;
        private System.Windows.Forms.TextBox txt_NomePaciente;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSala;
        private System.Windows.Forms.Label label6;
    }
}