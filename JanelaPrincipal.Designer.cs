namespace SistemaCadastroDeUsuario
{
    partial class JanelaPrincipal
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
            lblAcesso = new Label();
            mnu = new MenuStrip();
            mnuArquivo = new ToolStripMenuItem();
            mnuArquivoSair = new ToolStripMenuItem();
            mnuCadastro = new ToolStripMenuItem();
            mnuCadastroUsuario = new ToolStripMenuItem();
            mnuRelatorio = new ToolStripMenuItem();
            mnuRelatorioUsuario = new ToolStripMenuItem();
            mnuAjuda = new ToolStripMenuItem();
            mnuAjudaSobre = new ToolStripMenuItem();
            panel1.SuspendLayout();
            mnu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblAcesso);
            panel1.Controls.Add(mnu);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblAcesso
            // 
            lblAcesso.AutoSize = true;
            lblAcesso.Location = new Point(644, 396);
            lblAcesso.Name = "lblAcesso";
            lblAcesso.Size = new Size(0, 15);
            lblAcesso.TabIndex = 1;
            lblAcesso.Click += lblAcesso_Click;
            // 
            // mnu
            // 
            mnu.Items.AddRange(new ToolStripItem[] { mnuArquivo, mnuCadastro, mnuRelatorio, mnuAjuda });
            mnu.Location = new Point(0, 0);
            mnu.Name = "mnu";
            mnu.Size = new Size(776, 24);
            mnu.TabIndex = 0;
            mnu.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            mnuArquivo.DropDownItems.AddRange(new ToolStripItem[] { mnuArquivoSair });
            mnuArquivo.Name = "mnuArquivo";
            mnuArquivo.Size = new Size(61, 20);
            mnuArquivo.Text = "Arquivo";
            // 
            // mnuArquivoSair
            // 
            mnuArquivoSair.Name = "mnuArquivoSair";
            mnuArquivoSair.Size = new Size(93, 22);
            mnuArquivoSair.Text = "Sair";
            mnuArquivoSair.Click += mnuArquivoSair_Click;
            // 
            // mnuCadastro
            // 
            mnuCadastro.DropDownItems.AddRange(new ToolStripItem[] { mnuCadastroUsuario });
            mnuCadastro.Name = "mnuCadastro";
            mnuCadastro.Size = new Size(66, 20);
            mnuCadastro.Text = "Cadastro";
            // 
            // mnuCadastroUsuario
            // 
            mnuCadastroUsuario.Name = "mnuCadastroUsuario";
            mnuCadastroUsuario.Size = new Size(114, 22);
            mnuCadastroUsuario.Text = "Usuário";
            mnuCadastroUsuario.Click += usuárioToolStripMenuItem_Click;
            // 
            // mnuRelatorio
            // 
            mnuRelatorio.DropDownItems.AddRange(new ToolStripItem[] { mnuRelatorioUsuario });
            mnuRelatorio.Name = "mnuRelatorio";
            mnuRelatorio.Size = new Size(66, 20);
            mnuRelatorio.Text = "Relatorio";
            // 
            // mnuRelatorioUsuario
            // 
            mnuRelatorioUsuario.Name = "mnuRelatorioUsuario";
            mnuRelatorioUsuario.Size = new Size(119, 22);
            mnuRelatorioUsuario.Text = "Usuarios";
            // 
            // mnuAjuda
            // 
            mnuAjuda.DropDownItems.AddRange(new ToolStripItem[] { mnuAjudaSobre });
            mnuAjuda.Name = "mnuAjuda";
            mnuAjuda.Size = new Size(50, 20);
            mnuAjuda.Text = "Ajuda";
            // 
            // mnuAjudaSobre
            // 
            mnuAjudaSobre.Name = "mnuAjudaSobre";
            mnuAjudaSobre.Size = new Size(104, 22);
            mnuAjudaSobre.Text = "Sobre";
            mnuAjudaSobre.Click += mnuAjudaSobre_Click;
            // 
            // JanelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MainMenuStrip = mnu;
            Name = "JanelaPrincipal";
            Text = "Janela Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mnu.ResumeLayout(false);
            mnu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip mnu;
        private ToolStripMenuItem mnuArquivo;
        private ToolStripMenuItem mnuCadastro;
        private ToolStripMenuItem mnuArquivoSair;
        private ToolStripMenuItem mnuCadastroUsuario;
        private ToolStripMenuItem mnuRelatorio;
        private ToolStripMenuItem mnuAjuda;
        private ToolStripMenuItem mnuAjudaSobre;
        private ToolStripMenuItem mnuRelatorioUsuario;
        private Label label1;
        public Label lblAcesso;
    }
}