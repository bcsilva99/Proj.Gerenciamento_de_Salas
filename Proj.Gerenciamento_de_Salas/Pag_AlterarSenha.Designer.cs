
namespace Proj.Gerenciamento_de_Salas
{
    partial class Pag_AlterarSenha
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.panelAlterarSenha = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtConfimaSenha = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.labelConfirmarSenha = new System.Windows.Forms.Label();
            this.labelNovaSenha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAlterarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(608, 15);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(159, 42);
            this.btn_Voltar.TabIndex = 1;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(71, 17);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(65, 17);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuário :";
            // 
            // panelAlterarSenha
            // 
            this.panelAlterarSenha.Controls.Add(this.btnSalvar);
            this.panelAlterarSenha.Controls.Add(this.txtConfimaSenha);
            this.panelAlterarSenha.Controls.Add(this.txtNovaSenha);
            this.panelAlterarSenha.Controls.Add(this.TxtSenha);
            this.panelAlterarSenha.Controls.Add(this.txtUsuario);
            this.panelAlterarSenha.Controls.Add(this.labelConfirmarSenha);
            this.panelAlterarSenha.Controls.Add(this.labelNovaSenha);
            this.panelAlterarSenha.Controls.Add(this.label1);
            this.panelAlterarSenha.Controls.Add(this.labelUsuario);
            this.panelAlterarSenha.Location = new System.Drawing.Point(118, 110);
            this.panelAlterarSenha.Name = "panelAlterarSenha";
            this.panelAlterarSenha.Size = new System.Drawing.Size(484, 230);
            this.panelAlterarSenha.TabIndex = 3;
            this.panelAlterarSenha.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAlterarSenha_Paint);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(368, 188);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 39);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtConfimaSenha
            // 
            this.txtConfimaSenha.Location = new System.Drawing.Point(166, 98);
            this.txtConfimaSenha.Name = "txtConfimaSenha";
            this.txtConfimaSenha.Size = new System.Drawing.Size(315, 22);
            this.txtConfimaSenha.TabIndex = 9;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(166, 70);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(315, 22);
            this.txtNovaSenha.TabIndex = 8;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(166, 42);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(315, 22);
            this.TxtSenha.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(166, 14);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(315, 22);
            this.txtUsuario.TabIndex = 6;
            // 
            // labelConfirmarSenha
            // 
            this.labelConfirmarSenha.AutoSize = true;
            this.labelConfirmarSenha.Location = new System.Drawing.Point(14, 101);
            this.labelConfirmarSenha.Name = "labelConfirmarSenha";
            this.labelConfirmarSenha.Size = new System.Drawing.Size(122, 17);
            this.labelConfirmarSenha.TabIndex = 5;
            this.labelConfirmarSenha.Text = "Confirmar Senha :";
            // 
            // labelNovaSenha
            // 
            this.labelNovaSenha.AutoSize = true;
            this.labelNovaSenha.Location = new System.Drawing.Point(42, 73);
            this.labelNovaSenha.Name = "labelNovaSenha";
            this.labelNovaSenha.Size = new System.Drawing.Size(94, 17);
            this.labelNovaSenha.TabIndex = 4;
            this.labelNovaSenha.Text = "Nova Senha :";
            this.labelNovaSenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Senha :";
            // 
            // Pag_AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAlterarSenha);
            this.Controls.Add(this.btn_Voltar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Pag_AlterarSenha";
            this.Text = "Pag_AlterarSenha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pag_AlterarSenha_FormClosing);
            this.Load += new System.EventHandler(this.Pag_AlterarSenha_Load);
            this.panelAlterarSenha.ResumeLayout(false);
            this.panelAlterarSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Panel panelAlterarSenha;
        private System.Windows.Forms.Label labelConfirmarSenha;
        private System.Windows.Forms.Label labelNovaSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfimaSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnSalvar;
    }
}