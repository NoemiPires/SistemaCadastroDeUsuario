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
    public partial class RelatorioUltimosTrintaDias : Form
    {
        private static RelatorioUltimosTrintaDias _instance;
        public RelatorioUltimosTrintaDias()
        {
            InitializeComponent();

            List<Cliente> clientes = new List<Cliente>();
            clientes = ClienteRepository.FindAllNomes();
            lsbClientes.DisplayMember = "Nome";
            lsbClientes.Items.AddRange(clientes.ToArray());

            // Listar as compras dos ultimos 30 dias desse cliente
            DateTime dataLimite = DateTime.Now.AddDays(-30);
            List<Compra> comprasUltimosTrintaDias = new List<Compra>();
            foreach (Cliente cliente in clientes)
            {
                var compras = CompraRepository.FindByClienteId(cliente.Id)
                    .Where(c => c.Inicio >= dataLimite)
                    .ToList();
                comprasUltimosTrintaDias.AddRange(compras);
            }
            lsbCompras.DisplayMember = "inicio";
            lsbCompras.Items.AddRange(comprasUltimosTrintaDias.ToArray());

            // Assim que a compra for selecionada, exibir o total da
            // compra no lblTotalResposta e id no lblIdResposta
            lsbCompras.Click += (s, e) =>
            {
                if (lsbCompras.SelectedItem != null)
                {
                    Compra compraSelecionada = (Compra)lsbCompras.SelectedItem;
                    lblIdResposta.Text = compraSelecionada.Id.ToString();
                    lblTotalResposta.Text = $"{compraSelecionada.Total:C}";
                }
            };


        }

        public static RelatorioUltimosTrintaDias GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new RelatorioUltimosTrintaDias();
            }
            return _instance;
        }



        private void RelatorioUltimosTrintaDias_Load(object sender, EventArgs e)
        {

        }


    }
}
