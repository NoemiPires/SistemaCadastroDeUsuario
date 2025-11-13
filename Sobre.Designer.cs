namespace SistemaCadastroDeUsuario
{
    partial class Sobre
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
            panel1 = new Panel();
            lblNoemi = new Label();
            lblGiovanna = new Label();
            lblDesenvolvedores = new Label();
            lblVersoes = new Label();
            lblPrograma = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblNoemi);
            panel1.Controls.Add(lblGiovanna);
            panel1.Controls.Add(lblDesenvolvedores);
            panel1.Controls.Add(lblVersoes);
            panel1.Controls.Add(lblPrograma);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 142);
            panel1.TabIndex = 0;
            // 
            // lblNoemi
            // 
            lblNoemi.AutoSize = true;
            lblNoemi.Location = new Point(16, 113);
            lblNoemi.Name = "lblNoemi";
            lblNoemi.Size = new Size(114, 15);
            lblNoemi.TabIndex = 4;
            lblNoemi.Text = "Noemi da Silva Pires";
            // 
            // lblGiovanna
            // 
            lblGiovanna.AutoSize = true;
            lblGiovanna.Location = new Point(16, 98);
            lblGiovanna.Name = "lblGiovanna";
            lblGiovanna.Size = new Size(166, 15);
            lblGiovanna.TabIndex = 3;
            lblGiovanna.Text = "Giovanna Mellany Soares Silva";
            // 
            // lblDesenvolvedores
            // 
            lblDesenvolvedores.AutoSize = true;
            lblDesenvolvedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesenvolvedores.Location = new Point(3, 66);
            lblDesenvolvedores.Name = "lblDesenvolvedores";
            lblDesenvolvedores.Size = new Size(107, 15);
            lblDesenvolvedores.TabIndex = 2;
            lblDesenvolvedores.Text = "Desenvolvedores:";
            // 
            // lblVersoes
            // 
            lblVersoes.AutoSize = true;
            lblVersoes.Location = new Point(3, 38);
            lblVersoes.Name = "lblVersoes";
            lblVersoes.Size = new Size(59, 15);
            lblVersoes.TabIndex = 1;
            lblVersoes.Text = "Versão 1.0";
            // 
            // lblPrograma
            // 
            lblPrograma.AutoSize = true;
            lblPrograma.BackColor = Color.FromArgb(192, 192, 255);
            lblPrograma.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrograma.Location = new Point(3, 10);
            lblPrograma.Name = "lblPrograma";
            lblPrograma.Size = new Size(339, 25);
            lblPrograma.TabIndex = 0;
            lblPrograma.Text = "Programa Para Cadastro de Úsuarios";
            // 
            // Sobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 166);
            Controls.Add(panel1);
            Name = "Sobre";
            Text = "Sobre";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPrograma;
        private Label lblNoemi;
        private Label lblGiovanna;
        private Label lblDesenvolvedores;
        private Label lblVersoes;
    }
}