
namespace Proj.Gerenciamento_de_Salas
{
    partial class Pag_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(367, 190);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(252, 22);
            this.txt_Senha.TabIndex = 1;
            this.txt_Senha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(405, 482);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(172, 28);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "button1";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(367, 130);
            this.txt_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(252, 22);
            this.txt_Login.TabIndex = 3;
            // 
            // Pag_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 581);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Senha);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pag_Login";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pag_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Login;
    }
}

