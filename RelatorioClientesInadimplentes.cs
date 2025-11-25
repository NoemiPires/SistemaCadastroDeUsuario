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
    public partial class RelatorioClientesInadimplentes : Form
    {
        private static RelatorioClientesInadimplentes _instance;
        public RelatorioClientesInadimplentes()
        {
            InitializeComponent();

            lstClienteInadiplentes.DisplayMember = "Nome";
            lstClienteInadiplentes.Items.AddRange(ClienteRepository.FindByCompraPendente().ToArray());

        }

        public static RelatorioClientesInadimplentes GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new RelatorioClientesInadimplentes();
            }
            return _instance;
        }

        private void lstClienteInadiplentes_Click(object sender, EventArgs e)
        {
            Cliente? cliente = (Cliente?)lstClienteInadiplentes.SelectedItem;
            if (cliente == null)
            {
                return;
            }
            // Additional item-click behavior can be added here if needed.
            lblRespostaNome.Text = cliente.Nome;
            lblRespostaCpf.Text = cliente.Cpf;
        }
    }
}
