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
    public partial class Itens : Form
    {
        private static Itens _instance;
        public Itens()
        {
            InitializeComponent();
            // Carregar os produtos no ComboBox ao iniciar o formulário
            cmdCatergoria.Items.AddRange(ProdutoRepository.FindByNome("").Select(p => p.Nome).ToArray());
        }

        public static Itens GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Itens();
            }
            return _instance;
        }

        // Metodo para adicionar o item na lsbItens
        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            string nomeProduto = cmdCatergoria.SelectedItem.ToString();

                UInt32 quantidade = UInt32.Parse(txtQuantidade.Text);
                Decimal precoUnitario = Decimal.Parse(txtPreco.Text);
                Decimal desconto = Decimal.Parse(txtDesconto.Text);
            Item novoItem = new Item
            {
                Id = 0, // Será atribuído pelo repositório
                Quantidade = quantidade,
                PrecoUnitario = precoUnitario,
                Desconto = desconto,
                Produto = cmdCatergoria.SelectedItem as Produto
            };

        }

        public Decimal CalcularTotal(Item item)
        {
            // retornar a quantidade multiplicada pelo preco unitario menos o desconto
            return item.Quantidade * item.PrecoUnitario - (item.Quantidade * item.PrecoUnitario * (item.Desconto / 100m));

        }
    }
}
