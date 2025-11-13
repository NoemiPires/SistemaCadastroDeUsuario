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
            mnuJanelaPrincipal = new MenuStrip();
            mnuArquivo = new ToolStripMenuItem();
            mnuArquivoSair = new ToolStripMenuItem();
            mnuCadastro = new ToolStripMenuItem();
            mnuCadastroUsuario = new ToolStripMenuItem();
            mnuRelatorio = new ToolStripMenuItem();
            mnuRelatorioUsuario = new ToolStripMenuItem();
            mnuAjuda = new ToolStripMenuItem();
            mnuAjudaSobre = new ToolStripMenuItem();
            staBarraEstado = new StatusStrip();
            staBarraEstadoUltimoAcesso = new ToolStripStatusLabel();
            mnuJanelaPrincipal.SuspendLayout();
            staBarraEstado.SuspendLayout();
            SuspendLayout();
            // 
            // mnuJanelaPrincipal
            // 
            mnuJanelaPrincipal.Items.AddRange(new ToolStripItem[] { mnuArquivo, mnuCadastro, mnuRelatorio, mnuAjuda });
            mnuJanelaPrincipal.Location = new Point(0, 0);
            mnuJanelaPrincipal.Name = "mnuJanelaPrincipal";
            mnuJanelaPrincipal.Size = new Size(800, 24);
            mnuJanelaPrincipal.TabIndex = 1;
            mnuJanelaPrincipal.Text = "menuStrip1";
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
            mnuArquivoSair.Click += mnuArquivoSair_Click_1;
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
            mnuCadastroUsuario.Size = new Size(180, 22);
            mnuCadastroUsuario.Text = "Usuário";
            mnuCadastroUsuario.Click += mnuCadastroUsuario_Click;
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
            mnuRelatorioUsuario.Size = new Size(180, 22);
            mnuRelatorioUsuario.Text = "Usuarios";
            mnuRelatorioUsuario.Click += mnuRelatorioUsuario_Click;
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
            mnuAjudaSobre.Click += mnuAjudaSobre_Click_1;
            // 
            // staBarraEstado
            // 
            staBarraEstado.Items.AddRange(new ToolStripItem[] { staBarraEstadoUltimoAcesso });
            staBarraEstado.Location = new Point(0, 428);
            staBarraEstado.Name = "staBarraEstado";
            staBarraEstado.Size = new Size(800, 22);
            staBarraEstado.TabIndex = 3;
            staBarraEstado.Text = "statusStrip1";
            // 
            // staBarraEstadoUltimoAcesso
            // 
            staBarraEstadoUltimoAcesso.Name = "staBarraEstadoUltimoAcesso";
            staBarraEstadoUltimoAcesso.Size = new Size(118, 17);
            staBarraEstadoUltimoAcesso.Text = "toolStripStatusLabel1";
            // 
            // JanelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(staBarraEstado);
            Controls.Add(mnuJanelaPrincipal);
            IsMdiContainer = true;
            Name = "JanelaPrincipal";
            Text = "Janela Principal";
            FormClosed += JanelaPrincipal_FormClosed;
            mnuJanelaPrincipal.ResumeLayout(false);
            mnuJanelaPrincipal.PerformLayout();
            staBarraEstado.ResumeLayout(false);
            staBarraEstado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MenuStrip mnuJanelaPrincipal;
        private ToolStripMenuItem mnuArquivo;
        private ToolStripMenuItem mnuArquivoSair;
        private ToolStripMenuItem mnuCadastro;
        private ToolStripMenuItem mnuCadastroUsuario;
        private ToolStripMenuItem mnuRelatorio;
        private ToolStripMenuItem mnuRelatorioUsuario;
        private ToolStripMenuItem mnuAjuda;
        private ToolStripMenuItem mnuAjudaSobre;
        private StatusStrip staBarraEstado;
        private ToolStripStatusLabel staBarraEstadoUltimoAcesso;
    }
}