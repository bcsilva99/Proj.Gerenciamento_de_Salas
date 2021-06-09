
namespace Proj.Gerenciamento_de_Salas
{
    partial class Pag_Configuracao
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
            this.btn_QuantSalas = new System.Windows.Forms.Button();
            this.btn_NovoUsuário = new System.Windows.Forms.Button();
            this.btn_AlteraSenha = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_QuantSalas
            // 
            this.btn_QuantSalas.Location = new System.Drawing.Point(395, 134);
            this.btn_QuantSalas.Name = "btn_QuantSalas";
            this.btn_QuantSalas.Size = new System.Drawing.Size(127, 40);
            this.btn_QuantSalas.TabIndex = 0;
            this.btn_QuantSalas.Text = "Configuração de Salas";
            this.btn_QuantSalas.UseVisualStyleBackColor = true;
            this.btn_QuantSalas.Click += new System.EventHandler(this.btn_QuantSalas_Click);
            // 
            // btn_NovoUsuário
            // 
            this.btn_NovoUsuário.Location = new System.Drawing.Point(213, 134);
            this.btn_NovoUsuário.Name = "btn_NovoUsuário";
            this.btn_NovoUsuário.Size = new System.Drawing.Size(127, 40);
            this.btn_NovoUsuário.TabIndex = 1;
            this.btn_NovoUsuário.Text = "Novo Usuário";
            this.btn_NovoUsuário.UseVisualStyleBackColor = true;
            this.btn_NovoUsuário.Click += new System.EventHandler(this.btn_NovoUsuário_Click);
            // 
            // btn_AlteraSenha
            // 
            this.btn_AlteraSenha.Location = new System.Drawing.Point(36, 134);
            this.btn_AlteraSenha.Name = "btn_AlteraSenha";
            this.btn_AlteraSenha.Size = new System.Drawing.Size(127, 40);
            this.btn_AlteraSenha.TabIndex = 2;
            this.btn_AlteraSenha.Text = "Alterar Senha";
            this.btn_AlteraSenha.UseVisualStyleBackColor = true;
            this.btn_AlteraSenha.Click += new System.EventHandler(this.btn_AlteraSenha_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(432, 300);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(127, 40);
            this.btn_Menu.TabIndex = 3;
            this.btn_Menu.Text = "Voltar para o Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // Pag_Configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_AlteraSenha);
            this.Controls.Add(this.btn_NovoUsuário);
            this.Controls.Add(this.btn_QuantSalas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Pag_Configuracao";
            this.Text = "Pag_Configuracao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pag_Configuracao_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_QuantSalas;
        private System.Windows.Forms.Button btn_NovoUsuário;
        private System.Windows.Forms.Button btn_AlteraSenha;
        private System.Windows.Forms.Button btn_Menu;
    }
}