
namespace Proj.Gerenciamento_de_Salas
{
    partial class Pag_CalendarioMarcacao
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
            this.btn_NovaMarcacao = new System.Windows.Forms.Button();
            this.btn_EditarMarcacao = new System.Windows.Forms.Button();
            this.btn_EditarPaciente = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NovaMarcacao
            // 
            this.btn_NovaMarcacao.Location = new System.Drawing.Point(429, 19);
            this.btn_NovaMarcacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_NovaMarcacao.Name = "btn_NovaMarcacao";
            this.btn_NovaMarcacao.Size = new System.Drawing.Size(143, 38);
            this.btn_NovaMarcacao.TabIndex = 0;
            this.btn_NovaMarcacao.Text = "Nova Marcação";
            this.btn_NovaMarcacao.UseVisualStyleBackColor = true;
            this.btn_NovaMarcacao.Click += new System.EventHandler(this.btn_NovaMarcacao_Click);
            // 
            // btn_EditarMarcacao
            // 
            this.btn_EditarMarcacao.Location = new System.Drawing.Point(429, 100);
            this.btn_EditarMarcacao.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditarMarcacao.Name = "btn_EditarMarcacao";
            this.btn_EditarMarcacao.Size = new System.Drawing.Size(143, 38);
            this.btn_EditarMarcacao.TabIndex = 1;
            this.btn_EditarMarcacao.Text = "Editar Marcação";
            this.btn_EditarMarcacao.UseVisualStyleBackColor = true;
            this.btn_EditarMarcacao.Click += new System.EventHandler(this.btn_EditarMarcacao_Click);
            // 
            // btn_EditarPaciente
            // 
            this.btn_EditarPaciente.Location = new System.Drawing.Point(429, 179);
            this.btn_EditarPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditarPaciente.Name = "btn_EditarPaciente";
            this.btn_EditarPaciente.Size = new System.Drawing.Size(143, 38);
            this.btn_EditarPaciente.TabIndex = 2;
            this.btn_EditarPaciente.Text = "Editar Paciente";
            this.btn_EditarPaciente.UseVisualStyleBackColor = true;
            this.btn_EditarPaciente.Click += new System.EventHandler(this.btn_EditarPaciente_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(429, 258);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(143, 38);
            this.btn_Menu.TabIndex = 3;
            this.btn_Menu.Text = "Voltar para o Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // Pag_CalendarioMarcacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_EditarPaciente);
            this.Controls.Add(this.btn_EditarMarcacao);
            this.Controls.Add(this.btn_NovaMarcacao);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Pag_CalendarioMarcacao";
            this.Text = "Pag_CalendarioMarcacao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NovaMarcacao;
        private System.Windows.Forms.Button btn_EditarMarcacao;
        private System.Windows.Forms.Button btn_EditarPaciente;
        private System.Windows.Forms.Button btn_Menu;
    }
}