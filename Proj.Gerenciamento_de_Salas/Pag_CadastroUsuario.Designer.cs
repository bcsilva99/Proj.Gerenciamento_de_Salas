
namespace Proj.Gerenciamento_de_Salas
{
    partial class Pag_CadastroUsuario
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
            this.panelAlterarSenha = new System.Windows.Forms.Panel();
            this.checkedListAcessos = new System.Windows.Forms.CheckedListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.panelAlterarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(241, 237);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(87, 31);
            this.btn_Voltar.TabIndex = 2;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // panelAlterarSenha
            // 
            this.panelAlterarSenha.Controls.Add(this.checkedListAcessos);
            this.panelAlterarSenha.Controls.Add(this.btn_Voltar);
            this.panelAlterarSenha.Controls.Add(this.textBox2);
            this.panelAlterarSenha.Controls.Add(this.label3);
            this.panelAlterarSenha.Controls.Add(this.textBox1);
            this.panelAlterarSenha.Controls.Add(this.label2);
            this.panelAlterarSenha.Controls.Add(this.btnSalvar);
            this.panelAlterarSenha.Controls.Add(this.TxtSenha);
            this.panelAlterarSenha.Controls.Add(this.txtUsuario);
            this.panelAlterarSenha.Controls.Add(this.label1);
            this.panelAlterarSenha.Controls.Add(this.labelUsuario);
            this.panelAlterarSenha.Location = new System.Drawing.Point(62, 25);
            this.panelAlterarSenha.Margin = new System.Windows.Forms.Padding(2);
            this.panelAlterarSenha.Name = "panelAlterarSenha";
            this.panelAlterarSenha.Size = new System.Drawing.Size(363, 272);
            this.panelAlterarSenha.TabIndex = 4;
            // 
            // checkedListAcessos
            // 
            this.checkedListAcessos.CheckOnClick = true;
            this.checkedListAcessos.FormattingEnabled = true;
            this.checkedListAcessos.Items.AddRange(new object[] {
            "Pode Trocar de Senha",
            "Pode Editar Dados",
            "Pode Adicionar Dados",
            "Pode Alterar Configuração de Salas",
            "Pode Adiministrar Usuários"});
            this.checkedListAcessos.Location = new System.Drawing.Point(72, 153);
            this.checkedListAcessos.Name = "checkedListAcessos";
            this.checkedListAcessos.Size = new System.Drawing.Size(266, 79);
            this.checkedListAcessos.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 119);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID PUC :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome :";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(151, 237);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 32);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(72, 46);
            this.TxtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(266, 20);
            this.TxtSenha.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(72, 11);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(266, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Senha :";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(19, 18);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(49, 13);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuário :";
            // 
            // Pag_CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 359);
            this.Controls.Add(this.panelAlterarSenha);
            this.MaximizeBox = false;
            this.Name = "Pag_CadastroUsuario";
            this.Text = "Pag_CadastroUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pag_CadastroUsuario_FormClosing);
            this.panelAlterarSenha.ResumeLayout(false);
            this.panelAlterarSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Panel panelAlterarSenha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.CheckedListBox checkedListAcessos;
    }
}