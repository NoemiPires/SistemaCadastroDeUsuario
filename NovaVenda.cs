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
    public partial class NovaVenda : Form
    {
        private static NovaVenda _instance;
        public NovaVenda(Item item)
        {
            InitializeComponent();
            // LblNomeCliente vai receber o nome do cliente selecionado na janela ClienteCompra
            lblNomeCliente.Text = ClienteCompra.GetInstance().GetNomeCliente();
            // lblTotal vai se a soma do preco unitario de todos os itens adicionados na venda atraves da janela Itens
            lblTotal.Text = "Total: R$ " + Itens.GetInstance().CalcularTotal(item).ToString("F2");


        }

        public static NovaVenda GetInstance(Item item)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new NovaVenda(item);
            }
            return _instance;
        }

        private void NovaVenda_Load(object sender, EventArgs e)
        {
            Itens itens = Itens.GetInstance();
            itens.MdiParent = this;
            itens.BringToFront();
            itens.Show();

        }

        // Adicionar os itens cadastrados na lista de itens da venda lsbItens
        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
        }




    }
}
