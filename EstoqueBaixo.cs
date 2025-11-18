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
    public partial class EstoqueBaixo : Form
    {
        private static EstoqueBaixo _instance;
        public EstoqueBaixo()
        {
            InitializeComponent();
            List<Produto> produtos = new List<Produto>(); 
            produtos = ProdutoRepository.FindByEstoqueMinimo();
            lstEstoqueProdutos.Items.AddRange(produtos.ToArray());

        }

        public static EstoqueBaixo GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new EstoqueBaixo();
            }
            return _instance;
        }


        // Metodo para exibir os detalhes do produto selecionado na lista
        private void lstEstoqueProdutos_Click(object sender, EventArgs e)
        {
            Produto? produto = (Produto?)lstEstoqueProdutos.SelectedItem;
            lblIdDado.Text = produto.Id.ToString();
            lblNomeDado.Text = produto.Nome;
            lblPrecoDado.Text = produto.Preco.ToString("C2");
            lblEstoqueDado.Text = produto.Estoque.ToString();
            lblAtivoDado.Text = produto.Ativo ? "Sim" : "Não";
            lblCartegoriaDada.Text = produto.Categoria.Nome;
        }



    }
}
