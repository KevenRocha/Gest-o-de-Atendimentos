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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntRegistrar = new System.Windows.Forms.Button();
            this.Suporte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Solicitacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Empresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbHistorico = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.rtbHistorico);
            this.panel1.Controls.Add(this.bntRegistrar);
            this.panel1.Controls.Add(this.Suporte);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Solicitacao);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Telefone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Empresa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 427);
            this.panel1.TabIndex = 1;
            // 
            // bntRegistrar
            // 
            this.bntRegistrar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.bntRegistrar.Location = new System.Drawing.Point(175, 285);
            this.bntRegistrar.Name = "bntRegistrar";
            this.bntRegistrar.Size = new System.Drawing.Size(75, 23);
            this.bntRegistrar.TabIndex = 10;
            this.bntRegistrar.Text = "Registrar";
            this.bntRegistrar.UseVisualStyleBackColor = true;
            this.bntRegistrar.Click += new System.EventHandler(this.bntRegistrar_Click);
            // 
            // Suporte
            // 
            this.Suporte.Location = new System.Drawing.Point(175, 210);
            this.Suporte.Multiline = true;
            this.Suporte.Name = "Suporte";
            this.Suporte.Size = new System.Drawing.Size(162, 59);
            this.Suporte.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Suporte:";
            // 
            // Solicitacao
            // 
            this.Solicitacao.Location = new System.Drawing.Point(175, 150);
            this.Solicitacao.Multiline = true;
            this.Solicitacao.Name = "Solicitacao";
            this.Solicitacao.Size = new System.Drawing.Size(162, 54);
            this.Solicitacao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Solicitação:";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(175, 122);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(127, 22);
            this.Telefone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // Empresa
            // 
            this.Empresa.Location = new System.Drawing.Point(175, 94);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(127, 22);
            this.Empresa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(175, 66);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(127, 22);
            this.Nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // rtbHistorico
            // 
            this.rtbHistorico.Location = new System.Drawing.Point(509, 108);
            this.rtbHistorico.Name = "rtbHistorico";
            this.rtbHistorico.Size = new System.Drawing.Size(250, 161);
            this.rtbHistorico.TabIndex = 11;
            this.rtbHistorico.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(850, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Suporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Solicitacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntRegistrar;
        private System.Windows.Forms.RichTextBox rtbHistorico;
    }
}