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
    public partial class ClienteCompra : Form
    {
        private static ClienteCompra _instance;
        public ClienteCompra()
        {
            InitializeComponent();
            cmbClientes.DataSource = ClienteRepository.FindNomes();
        }

        public static ClienteCompra GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new ClienteCompra();
            }
            return _instance;
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {
            // Selecionar o cliente e converter o objeto do tipo String para o tipo cliente,
            // se  o cliente fazer parte da lista de inadimplentes do metodo de clienterepository FindByCompraPendente,
            // exibir aviso no lblAviso, se ele não estiver nessa lista, abrir a janela NovaVenda
            string nomeCliente = cmbClientes.SelectedItem.ToString();
            Cliente? cliente = ClienteRepository.FindByNome();
            if (cliente != null)
            {
                List<Cliente> clientesInadimplentes = ClienteRepository.FindByCompraPendente();
                if (clientesInadimplentes.Any(c => c.Id == cliente.Id))
                {
                    lblAviso.Visible = true;
                }
                else
                {
                    lblAviso.Visible = false;
                    Item item = new Item();
                    NovaVenda novaVenda = NovaVenda.GetInstance(item);
                    novaVenda.MdiParent = this.MdiParent;
                    novaVenda.BringToFront();
                    novaVenda.Show();
                    this.Close();
                }
            }
        }

        public String GetNomeCliente()
        {
            return cmbClientes.SelectedItem.ToString();
        }
    }
}
