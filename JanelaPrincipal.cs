using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastroDeUsuario
{
    public partial class JanelaPrincipal : Form
    {
        private static JanelaPrincipal _instance;

        public Usuario _usuario;
        // Change the access modifier of lblAcesso from private to public
        private Credencial? _credencial;
        private JanelaPrincipal(Usuario usuario)
        {
            InitializeComponent();

            Text = $"Sistema de Cadastro de Usuários - {usuario.Nome}";

            // Possivel erro
            mnuCadastroUsuario.Enabled = usuario.Credencial.Tipo == TipoUsuario.GERENTE;
            mnuCadastroNovaCategoria.Enabled = usuario.Credencial.Tipo == TipoUsuario.GERENTE;
            mnuCadastroNovoProduto.Enabled = usuario.Credencial.Tipo == TipoUsuario.GERENTE;
            novoClienteToolStripMenuItem.Enabled = usuario.Credencial.Tipo == TipoUsuario.GERENTE;
            mnuRelatorioEstoqueMinimo.Enabled = usuario.Credencial.Tipo == TipoUsuario.GERENTE;
            novoClienteToolStripMenuItem.Enabled = usuario.Credencial.Tipo == TipoUsuario.VENDEDOR;
            mnuRegistrarNovaVenda.Enabled = usuario.Credencial.Tipo == TipoUsuario.VENDEDOR;



            _usuario = usuario;

            staBarraEstadoUltimoAcesso.Text = "Último acesso: " + usuario.Credencial.UltimoAcesso;

            if (usuario.Credencial.UltimoAcesso == DateTime.MinValue)
            {
                staBarraEstadoUltimoAcesso.Visible = false;
            }


            //Text = "Sistema / " + usuario.Nome;
            //mnuCadastro.Enabled = usuario.Credencial.Gerente;

            //if (usuario.Credencial.UltimoAcesso == DateTime.MinValue)
            //    staBarraEstadoUltimoAcesso.Visible = false;

            //_credencial = UsuarioRepository.FindByIdWithCredencial(usuario.Id)?.Credencial;

            //staBarraEstadoUltimoAcesso.Text = $"Último Acesso: {_credencial.UltimoAcesso}";
        }

        public static JanelaPrincipal GetInstance(Usuario usuario)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanelaPrincipal(usuario);
            }
            return _instance;

        }

        private void JanelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            _usuario.Credencial.UltimoAcesso = DateTime.Now;
            UsuarioRepository.SaveOrUpdate(_usuario);

            JanelaEntrada.GetInstance().Show();
            JanelaEntrada.GetInstance().LimparCampos();
        }



        #region Mdiparents

        private void mnuArquivoSair_Click_1(object sender, EventArgs e)
        {
            _usuario.Credencial.UltimoAcesso = DateTime.Now;
            UsuarioRepository.SaveOrUpdate(_usuario);

            JanelaEntrada.GetInstance().Show();
            JanelaEntrada.GetInstance().LimparCampos();
            Close();

        }

        private void mnuAjudaSobre_Click_1(object sender, EventArgs e)
        {
            Sobre sobre = Sobre.GetInstance();
            sobre.MdiParent = this;
            sobre.WindowState = FormWindowState.Normal;
            sobre.BringToFront();
            sobre.Show();
        }

        private void mnuCadastroUsuario_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastro = CadastroUsuario.GetInstance();
            cadastro.MdiParent = this;
            cadastro.WindowState = FormWindowState.Normal;
            cadastro.BringToFront();
            cadastro.Show();
        }

        private void mnuRelatorioUsuario_Click(object sender, EventArgs e)
        {

            UsuariosCadastrados usuario = UsuariosCadastrados.GetInstance();
            usuario.MdiParent = this;
            usuario.WindowState = FormWindowState.Normal;
            usuario.BringToFront();
            usuario.Show();
        }

        private void mnuRelatorioVendas_Click(object sender, EventArgs e)
        {
            VendasCadastradas vendas = VendasCadastradas.GetInstance();
            vendas.MdiParent = this;
            vendas.WindowState = FormWindowState.Normal;
            vendas.BringToFront();
            vendas.Show();
        }

        private void mnuRelatorioEstoqueMinimo_Click(object sender, EventArgs e)
        {
            EstoqueBaixo estoqueBaixo = EstoqueBaixo.GetInstance();
            estoqueBaixo.MdiParent = this;
            estoqueBaixo.WindowState = FormWindowState.Normal;
            estoqueBaixo.BringToFront();
            estoqueBaixo.Show();

        }

        private void mnuCadastroNovoProduto_Click(object sender, EventArgs e)
        {
            Categoria categoria = CategoriaRepository.FindAll().First();
            CadastrarProdutos cadastrar = CadastrarProdutos.GetInstance(categoria);
            cadastrar.MdiParent = this;
            cadastrar.BringToFront();
            cadastrar.Show();
        }

        private void mnuCadastroNovaCategoria_Click_1(object sender, EventArgs e)
        {
            CadastrarCategoria categoria = CadastrarCategoria.GetInstance();
            categoria.MdiParent = this;
            categoria.BringToFront();
            categoria.Show();
        }

        private void mnuRelatorioCompraVendas_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Today;
            RelatorioTotalPeriodo vendas = RelatorioTotalPeriodo.GetInstance(data);
            vendas.MdiParent = this;
            vendas.WindowState = FormWindowState.Normal;
            vendas.BringToFront();
            vendas.Show();
        }

        private void mnuRelatorioCompraComissao_Click(object sender, EventArgs e)
        {
            RelatorioComissaoPeriodo comissao = RelatorioComissaoPeriodo.GetInstance((UInt32)_usuario.Id);
            comissao.MdiParent = this;
            comissao.WindowState = FormWindowState.Normal;
            comissao.BringToFront();
            comissao.Show();
        }

        private void inadiplentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioClientesInadimplentes inadimplentes = RelatorioClientesInadimplentes.GetInstance();
            inadimplentes.MdiParent = this;
            inadimplentes.WindowState = FormWindowState.Normal;
            inadimplentes.BringToFront();
            inadimplentes.Show();
        }

        private void ultimosTrintaDiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioUltimosTrintaDias relatorio = RelatorioUltimosTrintaDias.GetInstance();
            relatorio.MdiParent = this;
            relatorio.WindowState = FormWindowState.Normal;
            relatorio.BringToFront();
            relatorio.Show();
        }

        private void mnuRegistrarNovaVenda_Click(object sender, EventArgs e)
        {
            ClienteCompra clienteCompra = ClienteCompra.GetInstance();
            clienteCompra.MdiParent = this;
            clienteCompra.BringToFront();
            clienteCompra.Show();
        }


        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = CadastrarCliente.GetInstance();
            cadastrarCliente.MdiParent = this;
            cadastrarCliente.BringToFront();
            cadastrarCliente.Show();

        }
        #endregion


        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {
            // Se o usuario for gerente abrir a janela Estoque baixo automaticamente
            if (_usuario.Credencial.Tipo == TipoUsuario.GERENTE)
            {
                mnuRelatorioEstoqueMinimo_Click(sender, e);
            }
        }

    }
}