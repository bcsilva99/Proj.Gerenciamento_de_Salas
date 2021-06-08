
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EsqueciSenha = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(125, 87);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(273, 20);
            this.txt_Senha.TabIndex = 1;
            this.txt_Senha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(139, 321);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(129, 23);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Entrar";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(125, 55);
            this.txt_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(273, 20);
            this.txt_Login.TabIndex = 3;
            this.txt_Login.TextChanged += new System.EventHandler(this.txt_Login_TextChanged);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btn_EsqueciSenha);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.txt_Login);
            this.panelLogin.Controls.Add(this.btn_Login);
            this.panelLogin.Controls.Add(this.txt_Senha);
            this.panelLogin.Location = new System.Drawing.Point(154, 53);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(400, 348);
            this.panelLogin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuário:";
            // 
            // btn_EsqueciSenha
            // 
            this.btn_EsqueciSenha.Location = new System.Drawing.Point(4, 321);
            this.btn_EsqueciSenha.Name = "btn_EsqueciSenha";
            this.btn_EsqueciSenha.Size = new System.Drawing.Size(129, 23);
            this.btn_EsqueciSenha.TabIndex = 6;
            this.btn_EsqueciSenha.Text = "Esqueci a Senha";
            this.btn_EsqueciSenha.UseVisualStyleBackColor = true;
            // 
            // Pag_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 472);
            this.Controls.Add(this.panelLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pag_Login";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pag_Login_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EsqueciSenha;
    }
}

