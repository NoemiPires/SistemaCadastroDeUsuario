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
            // lblTotal vai se a soma do preco unitario de todos os itens adicionados na venda atraves da lsbItens


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
            // encontrar o id do cliente atraves do nome exibido no lblNomeCliente usando o metodo FindIdByNome da classe ClienteRepository
            UInt32? idCliente = ClienteRepository.FindIdByNome(lblNomeCliente.Text);

            Compra compra = new Compra();
            compra.Itens = lsbItens.Items.Cast<Item>().ToList();
            compra.Cliente = ClienteRepository.FindById((UInt32)idCliente);



        }



        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            // Salvar o item na lsbItens, e atualizar o lblTotal com o valor total da venda. Alem de adiciona

        }




    }
}
