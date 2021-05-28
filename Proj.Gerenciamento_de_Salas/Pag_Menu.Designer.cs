
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
            this.btn_AbreTela1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AbreTela1
            // 
            this.btn_AbreTela1.Location = new System.Drawing.Point(373, 96);
            this.btn_AbreTela1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AbreTela1.Name = "btn_AbreTela1";
            this.btn_AbreTela1.Size = new System.Drawing.Size(156, 42);
            this.btn_AbreTela1.TabIndex = 0;
            this.btn_AbreTela1.Text = "botao";
            this.btn_AbreTela1.UseVisualStyleBackColor = true;
            // 
            // Pag_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_AbreTela1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Pag_Menu";
            this.Text = "Pag_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AbreTela1;
    }
}