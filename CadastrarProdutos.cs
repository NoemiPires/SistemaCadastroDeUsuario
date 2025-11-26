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
    public partial class CadastrarProdutos : Form
    {
        private static CadastrarProdutos _intance;
        public CadastrarProdutos(Categoria categoria)
        {
            InitializeComponent();
            cmdCatergoria.DataSource = CategoriaRepository.ListarNomesCategorias();

        }

        public static CadastrarProdutos GetInstance(Categoria categoria)
        {
            if (_intance == null || _intance.IsDisposed)
            {
                _intance = new CadastrarProdutos(categoria);
            }
            return _intance;
        }


        private void cmbCatergoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Categoria> categorias = CategoriaRepository.FindAll();
        }

        #region KeyUp Events

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            txtPreco.Focus();
            txtPreco.SelectAll();
        }
        private void txtPreco_KeyUp(object sender, KeyEventArgs e)
        {
            txtEstoque.Focus();
            txtEstoque.SelectAll();
        }
        private void txtEstoque_KeyUp(object sender, KeyEventArgs e)
        {
            cmdCatergoria.Focus();
        }
        #endregion

        #region Salvar Produto
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text;
            produto.Preco = Decimal.Parse(txtPreco.Text);
            produto.Estoque = UInt32.Parse(txtEstoque.Text);
            produto.Ativo = ckhAtivo.Checked;

            // Buscar o id da categoria selecionada no combobox
            UInt32? categoriaId = CategoriaRepository.BuscarIdPorNome(cmdCatergoria.SelectedItem?.ToString());
            if (categoriaId.HasValue)
            {
                // Carrega a entidade Categoria do repositório e atribui como navegação
                Categoria categoria = CategoriaRepository.FindById(categoriaId.Value);
                if (categoria != null)
                {
                    produto.CategoriaId = categoria;
                }
            }
            ProdutoRepository.SaveOrUpdate(produto);

            lblaprodutoCadastrado.Visible = true;

            txtNome.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
            txtNome.Focus();
            cmdCatergoria.SelectedIndex = -1;
            ckhAtivo.Checked = false;


        }

        #endregion

    }
}
