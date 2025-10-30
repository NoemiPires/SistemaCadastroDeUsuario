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
            mnu = new MenuStrip();
            mnuArquivo = new ToolStripMenuItem();
            mnuArquivoSair = new ToolStripMenuItem();
            mnuCadastro = new ToolStripMenuItem();
            mnuCadastroUsuario = new ToolStripMenuItem();
            mnuRelatorio = new ToolStripMenuItem();
            mnuRelatorioUsuario = new ToolStripMenuItem();
            mnuAjuda = new ToolStripMenuItem();
            mnuAjudaSobre = new ToolStripMenuItem();
            lblAcesso = new Label();
            mnu.SuspendLayout();
            SuspendLayout();
            // 
            // mnu
            // 
            mnu.Items.AddRange(new ToolStripItem[] { mnuArquivo, mnuCadastro, mnuRelatorio, mnuAjuda });
            mnu.Location = new Point(0, 0);
            mnu.Name = "mnu";
            mnu.Size = new Size(800, 24);
            mnu.TabIndex = 1;
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
            // 
            // lblAcesso
            // 
            lblAcesso.AutoSize = true;
            lblAcesso.Location = new Point(626, 384);
            lblAcesso.Name = "lblAcesso";
            lblAcesso.Size = new Size(12, 15);
            lblAcesso.TabIndex = 2;
            lblAcesso.Text = "°";
            // 
            // JanelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAcesso);
            Controls.Add(mnu);
            Name = "JanelaPrincipal";
            Text = "Janela Principal";
            FormClosed += JanelaPrincipal_FormClosed;
            mnu.ResumeLayout(false);
            mnu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MenuStrip mnu;
        private ToolStripMenuItem mnuArquivo;
        private ToolStripMenuItem mnuArquivoSair;
        private ToolStripMenuItem mnuCadastro;
        private ToolStripMenuItem mnuCadastroUsuario;
        private ToolStripMenuItem mnuRelatorio;
        private ToolStripMenuItem mnuRelatorioUsuario;
        private ToolStripMenuItem mnuAjuda;
        private ToolStripMenuItem mnuAjudaSobre;
        public Label lblAcesso;
    }
}