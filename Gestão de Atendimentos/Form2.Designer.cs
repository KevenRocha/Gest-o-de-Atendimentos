namespace Gestão_de_Atendimentos
{
    partial class Form2
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxSolicitacao = new System.Windows.Forms.TextBox();
            this.textBoxSuporte = new System.Windows.Forms.TextBox();
            this.button1Registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(234, 64);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(182, 22);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Location = new System.Drawing.Point(274, 104);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmpresa.TabIndex = 1;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(334, 159);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(100, 22);
            this.textBoxTelefone.TabIndex = 2;
            // 
            // textBoxSolicitacao
            // 
            this.textBoxSolicitacao.Location = new System.Drawing.Point(315, 215);
            this.textBoxSolicitacao.Name = "textBoxSolicitacao";
            this.textBoxSolicitacao.Size = new System.Drawing.Size(100, 22);
            this.textBoxSolicitacao.TabIndex = 3;
            // 
            // textBoxSuporte
            // 
            this.textBoxSuporte.Location = new System.Drawing.Point(333, 276);
            this.textBoxSuporte.Name = "textBoxSuporte";
            this.textBoxSuporte.Size = new System.Drawing.Size(100, 22);
            this.textBoxSuporte.TabIndex = 4;
            // 
            // button1Registrar
            // 
            this.button1Registrar.Location = new System.Drawing.Point(382, 353);
            this.button1Registrar.Name = "button1Registrar";
            this.button1Registrar.Size = new System.Drawing.Size(75, 23);
            this.button1Registrar.TabIndex = 5;
            this.button1Registrar.Text = "Registrar";
            this.button1Registrar.UseVisualStyleBackColor = true;
            this.button1Registrar.Click += new System.EventHandler(this.button1Registrar_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1Registrar);
            this.Controls.Add(this.textBoxSuporte);
            this.Controls.Add(this.textBoxSolicitacao);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxEmpresa);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmpresa;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxSolicitacao;
        private System.Windows.Forms.TextBox textBoxSuporte;
        private System.Windows.Forms.Button button1Registrar;
    }
}