
namespace Proj.Gerenciamento_de_Salas
{
    partial class Pag_Menu
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
            this.btn_Calendario = new System.Windows.Forms.Button();
            this.btn_AbreConfig = new System.Windows.Forms.Button();
            this.btn_RegistroAluno = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Calendario
            // 
            this.btn_Calendario.Location = new System.Drawing.Point(4, 4);
            this.btn_Calendario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Calendario.Name = "btn_Calendario";
            this.btn_Calendario.Size = new System.Drawing.Size(156, 42);
            this.btn_Calendario.TabIndex = 0;
            this.btn_Calendario.Text = "Calendário";
            this.btn_Calendario.UseVisualStyleBackColor = true;
            this.btn_Calendario.Click += new System.EventHandler(this.btn_Calendario_Click);
            // 
            // btn_AbreConfig
            // 
            this.btn_AbreConfig.Location = new System.Drawing.Point(610, 4);
            this.btn_AbreConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AbreConfig.Name = "btn_AbreConfig";
            this.btn_AbreConfig.Size = new System.Drawing.Size(156, 42);
            this.btn_AbreConfig.TabIndex = 1;
            this.btn_AbreConfig.Text = "Configurações";
            this.btn_AbreConfig.UseVisualStyleBackColor = true;
            this.btn_AbreConfig.Click += new System.EventHandler(this.btn_AbreConfig_Click);
            // 
            // btn_RegistroAluno
            // 
            this.btn_RegistroAluno.Location = new System.Drawing.Point(315, 4);
            this.btn_RegistroAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RegistroAluno.Name = "btn_RegistroAluno";
            this.btn_RegistroAluno.Size = new System.Drawing.Size(156, 42);
            this.btn_RegistroAluno.TabIndex = 2;
            this.btn_RegistroAluno.Text = "Registros Alunos";
            this.btn_RegistroAluno.UseVisualStyleBackColor = true;
            this.btn_RegistroAluno.Click += new System.EventHandler(this.btn_RegistroAluno_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(898, 32);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(156, 42);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btn_Calendario);
            this.panelMenu.Controls.Add(this.btn_RegistroAluno);
            this.panelMenu.Controls.Add(this.btn_AbreConfig);
            this.panelMenu.Location = new System.Drawing.Point(96, 282);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(770, 52);
            this.panelMenu.TabIndex = 4;
            // 
            // Pag_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.btn_Sair);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Pag_Menu";
            this.Text = "Pag_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pag_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Pag_Menu_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Calendario;
        private System.Windows.Forms.Button btn_AbreConfig;
        private System.Windows.Forms.Button btn_RegistroAluno;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Panel panelMenu;
    }
}