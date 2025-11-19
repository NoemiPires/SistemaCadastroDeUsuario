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
    public partial class VendasCadastradas : Form
    {
        private static VendasCadastradas _instance;

        private static Usuario _usuario;

        public VendasCadastradas()
        {
            InitializeComponent();
        }

        public static VendasCadastradas GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new VendasCadastradas();
            }
            return _instance;
        }

        private void lstVendasCadastradas_Click(object sender, EventArgs e)
        {
            Compra? compra = (Compra?)lstVendasCadastradas.SelectedItem;

            if (compra == null)
            {
                return;
            }

            // String? perfil = Usuario.Credencial.TipoUsuario;

            if (_usuario.Credencial.PermitirAcesso() == false)
            {
                lblPagamentoEfetuado.Visible = false;
                lblPagamentoPendente.Visible = false;
            }
            else
            {
                lblPagamentoEfetuado.Visible = true;
                lblPagamentoPendente.Visible = true;
            }

            lblIdDado.Text = compra.Id.ToString();
            lblPrecoDado.Text = compra.Total.ToString();
            lblCliente.Text = 



            // grpCadastros.Visible = true;
        }
    }
}
