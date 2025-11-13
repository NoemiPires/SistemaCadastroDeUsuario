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
        private CadastrarProdutos _intance;
        public CadastrarProdutos()
        {
            InitializeComponent();
        }

        public CadastrarProdutos GetInstance()
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


    }
}
