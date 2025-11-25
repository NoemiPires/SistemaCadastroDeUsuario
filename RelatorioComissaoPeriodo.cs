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
    public partial class RelatorioComissaoPeriodo : Form
    {
        private static RelatorioComissaoPeriodo _instance;
        public RelatorioComissaoPeriodo(DateTime data)
        {
            InitializeComponent();

            lstVendedores.DisplayMember = "NomeCompleto";
            List<Usuario> usuarios = UsuarioRepository.FindNomeByTipoVendedor();
            lstVendedores.Items.AddRange(usuarios.ToArray());

            lstPeriodo.DisplayMember = "inicio";
            List<Compra> compras = new List<Compra>();
            compras = CompraRepository.FindByData(data);
            lstPeriodo.Items.AddRange(compras.ToArray());
        }
        public static RelatorioComissaoPeriodo GetInstance(DateTime data)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new RelatorioComissaoPeriodo(data);
            }
            return _instance;
        }

        private void lstVendedores_Click(object sender, EventArgs e)
        {
            Usuario? usuario = (Usuario?)lstVendedores.SelectedItem;
            if (usuario == null)
            {
                return;
            }
            // Additional item-click behavior can be added here if needed.

        }
    }
}
