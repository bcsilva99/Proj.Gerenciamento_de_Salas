
namespace Proj.Gerenciamento_de_Salas
{
    partial class Pag_AdicionarAluno
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelDia = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxDia = new System.Windows.Forms.ComboBox();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.labelTurno = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(3, 3);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(119, 34);
            this.btn_Voltar.TabIndex = 1;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 287);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(62, 143);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(410, 20);
            this.textBox5.TabIndex = 6;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(59, 77);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(59, 127);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(59, 210);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 10;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Location = new System.Drawing.Point(394, 210);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(112, 13);
            this.labelDia.TabIndex = 11;
            this.labelDia.Text = "Dia de Disponibilidade";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(59, 271);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(43, 13);
            this.labelID.TabIndex = 12;
            this.labelID.Text = "ID PUC";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(130, 3);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(119, 34);
            this.btn_Salvar.TabIndex = 13;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Salvar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Voltar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(524, 453);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 45);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // comboBoxDia
            // 
            this.comboBoxDia.FormattingEnabled = true;
            this.comboBoxDia.Items.AddRange(new object[] {
            "Segunda- feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado"});
            this.comboBoxDia.Location = new System.Drawing.Point(397, 226);
            this.comboBoxDia.Name = "comboBoxDia";
            this.comboBoxDia.Size = new System.Drawing.Size(185, 21);
            this.comboBoxDia.TabIndex = 15;
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Items.AddRange(new object[] {
            "Pela Manhã",
            "Pela Tarde"});
            this.comboBoxTurno.Location = new System.Drawing.Point(397, 287);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(185, 21);
            this.comboBoxTurno.TabIndex = 17;
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Location = new System.Drawing.Point(394, 271);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(124, 13);
            this.labelTurno.TabIndex = 16;
            this.labelTurno.Text = "Turno de Disponibilidade";
            // 
            // Pag_AdicionarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 510);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxTurno);
            this.Controls.Add(this.labelTurno);
            this.Controls.Add(this.comboBoxDia);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelDia);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(844, 549);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(844, 549);
            this.Name = "Pag_AdicionarAluno";
            this.ShowInTaskbar = false;
            this.Text = "Pag_AdicionarAluno";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxDia;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.Label labelTurno;
    }
}