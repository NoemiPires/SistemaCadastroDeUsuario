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
            novoClienteToolStripMenuItem = new ToolStripMenuItem();
            mnuCadastroNovaCategoria = new ToolStripMenuItem();
            mnuCadastroNovoProduto = new ToolStripMenuItem();
            mnuVenda = new ToolStripMenuItem();
            mnuRegistrarNovaVenda = new ToolStripMenuItem();
            mnuRelatorio = new ToolStripMenuItem();
            mnuRelatorioUsuario = new ToolStripMenuItem();
            mnuRelatorioVendas = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            mnuRelatorioEstoqueMinimo = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            mnuRelatorioCompraVendas = new ToolStripMenuItem();
            mnuRelatorioCompraComissao = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            inadiplentesToolStripMenuItem = new ToolStripMenuItem();
            ultimosTrintaDiasToolStripMenuItem = new ToolStripMenuItem();
            mnuAjuda = new ToolStripMenuItem();
            mnuAjudaSobre = new ToolStripMenuItem();
            staBarraEstado = new StatusStrip();
            staBarraEstadoUltimoAcesso = new ToolStripStatusLabel();
            registraPagamentoToolStripMenuItem = new ToolStripMenuItem();
            mnuJanelaPrincipal.SuspendLayout();
            staBarraEstado.SuspendLayout();
            SuspendLayout();
            // 
            // mnuJanelaPrincipal
            // 
            mnuJanelaPrincipal.Items.AddRange(new ToolStripItem[] { mnuArquivo, mnuCadastro, mnuVenda, mnuRelatorio, mnuAjuda });
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
            mnuCadastro.DropDownItems.AddRange(new ToolStripItem[] { mnuCadastroUsuario, novoClienteToolStripMenuItem, mnuCadastroNovaCategoria, mnuCadastroNovoProduto });
            mnuCadastro.Name = "mnuCadastro";
            mnuCadastro.Size = new Size(66, 20);
            mnuCadastro.Text = "Cadastro";
            // 
            // mnuCadastroUsuario
            // 
            mnuCadastroUsuario.Name = "mnuCadastroUsuario";
            mnuCadastroUsuario.Size = new Size(156, 22);
            mnuCadastroUsuario.Text = "Novo Usuário";
            mnuCadastroUsuario.Click += mnuCadastroUsuario_Click;
            // 
            // novoClienteToolStripMenuItem
            // 
            novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            novoClienteToolStripMenuItem.Size = new Size(156, 22);
            novoClienteToolStripMenuItem.Text = "Novo Cliente";
            novoClienteToolStripMenuItem.Click += novoClienteToolStripMenuItem_Click;
            // 
            // mnuCadastroNovaCategoria
            // 
            mnuCadastroNovaCategoria.Name = "mnuCadastroNovaCategoria";
            mnuCadastroNovaCategoria.Size = new Size(156, 22);
            mnuCadastroNovaCategoria.Text = "Nova Categoria";
            mnuCadastroNovaCategoria.Click += mnuCadastroNovaCategoria_Click_1;
            // 
            // mnuCadastroNovoProduto
            // 
            mnuCadastroNovoProduto.Name = "mnuCadastroNovoProduto";
            mnuCadastroNovoProduto.Size = new Size(156, 22);
            mnuCadastroNovoProduto.Text = "Novo Produto";
            mnuCadastroNovoProduto.Click += mnuCadastroNovoProduto_Click;
            // 
            // mnuVenda
            // 
            mnuVenda.DropDownItems.AddRange(new ToolStripItem[] { mnuRegistrarNovaVenda, registraPagamentoToolStripMenuItem });
            mnuVenda.Name = "mnuVenda";
            mnuVenda.Size = new Size(51, 20);
            mnuVenda.Text = "Venda";
            // 
            // mnuRegistrarNovaVenda
            // 
            mnuRegistrarNovaVenda.Name = "mnuRegistrarNovaVenda";
            mnuRegistrarNovaVenda.Size = new Size(186, 22);
            mnuRegistrarNovaVenda.Text = "Registrar Nova Venda";
            mnuRegistrarNovaVenda.Click += mnuRegistrarNovaVenda_Click;
            // 
            // mnuRelatorio
            // 
            mnuRelatorio.DropDownItems.AddRange(new ToolStripItem[] { mnuRelatorioUsuario, mnuRelatorioVendas, estoqueToolStripMenuItem, cToolStripMenuItem, clientesToolStripMenuItem });
            mnuRelatorio.Name = "mnuRelatorio";
            mnuRelatorio.Size = new Size(66, 20);
            mnuRelatorio.Text = "Relatorio";
            // 
            // mnuRelatorioUsuario
            // 
            mnuRelatorioUsuario.Name = "mnuRelatorioUsuario";
            mnuRelatorioUsuario.Size = new Size(119, 22);
            mnuRelatorioUsuario.Text = "Usuarios";
            mnuRelatorioUsuario.Click += mnuRelatorioUsuario_Click;
            // 
            // mnuRelatorioVendas
            // 
            mnuRelatorioVendas.Name = "mnuRelatorioVendas";
            mnuRelatorioVendas.Size = new Size(119, 22);
            mnuRelatorioVendas.Text = "Vendas";
            mnuRelatorioVendas.Click += mnuRelatorioVendas_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuRelatorioEstoqueMinimo });
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(119, 22);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // mnuRelatorioEstoqueMinimo
            // 
            mnuRelatorioEstoqueMinimo.Name = "mnuRelatorioEstoqueMinimo";
            mnuRelatorioEstoqueMinimo.Size = new Size(116, 22);
            mnuRelatorioEstoqueMinimo.Text = "Minimo";
            mnuRelatorioEstoqueMinimo.Click += mnuRelatorioEstoqueMinimo_Click;
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuRelatorioCompraVendas, mnuRelatorioCompraComissao });
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(119, 22);
            cToolStripMenuItem.Text = "Compra";
            // 
            // mnuRelatorioCompraVendas
            // 
            mnuRelatorioCompraVendas.Name = "mnuRelatorioCompraVendas";
            mnuRelatorioCompraVendas.Size = new Size(197, 22);
            mnuRelatorioCompraVendas.Text = "Vendas por Periodo";
            mnuRelatorioCompraVendas.Click += mnuRelatorioCompraVendas_Click;
            // 
            // mnuRelatorioCompraComissao
            // 
            mnuRelatorioCompraComissao.Name = "mnuRelatorioCompraComissao";
            mnuRelatorioCompraComissao.Size = new Size(197, 22);
            mnuRelatorioCompraComissao.Text = "Comissao Do Vendedor";
            mnuRelatorioCompraComissao.Click += mnuRelatorioCompraComissao_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inadiplentesToolStripMenuItem, ultimosTrintaDiasToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(119, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // inadiplentesToolStripMenuItem
            // 
            inadiplentesToolStripMenuItem.Name = "inadiplentesToolStripMenuItem";
            inadiplentesToolStripMenuItem.Size = new Size(173, 22);
            inadiplentesToolStripMenuItem.Text = "Inadiplentes";
            inadiplentesToolStripMenuItem.Click += inadiplentesToolStripMenuItem_Click;
            // 
            // ultimosTrintaDiasToolStripMenuItem
            // 
            ultimosTrintaDiasToolStripMenuItem.Name = "ultimosTrintaDiasToolStripMenuItem";
            ultimosTrintaDiasToolStripMenuItem.Size = new Size(173, 22);
            ultimosTrintaDiasToolStripMenuItem.Text = "Ultimos Trinta Dias";
            ultimosTrintaDiasToolStripMenuItem.Click += ultimosTrintaDiasToolStripMenuItem_Click;
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
            // registraPagamentoToolStripMenuItem
            // 
            registraPagamentoToolStripMenuItem.Name = "registraPagamentoToolStripMenuItem";
            registraPagamentoToolStripMenuItem.Size = new Size(186, 22);
            registraPagamentoToolStripMenuItem.Text = "Registra Pagamento";
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
            Load += JanelaPrincipal_Load;
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
        private ToolStripMenuItem mnuRelatorioVendas;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem mnuRelatorioEstoqueMinimo;
        private ToolStripMenuItem mnuCadastroNovoProduto;
        private ToolStripMenuItem mnuCadastroNovaCategoria;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem mnuRelatorioCompraVendas;
        private ToolStripMenuItem mnuRelatorioCompraComissao;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem inadiplentesToolStripMenuItem;
        private ToolStripMenuItem ultimosTrintaDiasToolStripMenuItem;
        private ToolStripMenuItem novoClienteToolStripMenuItem;
        private ToolStripMenuItem mnuVenda;
        private ToolStripMenuItem mnuRegistrarNovaVenda;
        private ToolStripMenuItem registraPagamentoToolStripMenuItem;
    }
}