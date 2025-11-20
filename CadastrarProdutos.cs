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
        public CadastrarProdutos()
        {
            InitializeComponent();
        }

        public static CadastrarProdutos GetInstance()
        {
            if (_intance == null || _intance.IsDisposed)
            {
                _intance = new CadastrarProdutos();
            }
            return _intance;
        }


        private void cmbCatergoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Categoria> categorias = CategoriaRepository.FindAll();
        }

        #region KeyUp Events
        private void txtId_KeyUp(object sender, KeyEventArgs e)
        {
            txtNome.Focus();
            txtNome.SelectAll();
        }

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
            cmbCatergoria.Focus();
        }
        #endregion

        #region Salvar Produto
        private void Save()
        {
            Produto produto = new Produto();
            produto.Id = UInt32.Parse(txtId.Text);
            produto.Nome = txtNome.Text;
            produto.Preco = Decimal.Parse(txtPreco.Text);
            produto.Estoque = UInt32.Parse(txtEstoque.Text);
            produto.Categoria = (Categoria)cmbCatergoria.SelectedItem;
            
            ProdutoRepository.SaveOrUpdate(produto);

            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
            cmbCatergoria.SelectedIndex = -1;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Save();
        }
        #endregion

    }
}
