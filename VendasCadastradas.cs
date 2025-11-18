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

            if (PermitirUsuario() = false)
            {
                lblPagamentoEfetuado.Visible = false;
                lblPagamentoPendente.Visible = false;
            }
          
            lblNomeDado.Text = usuario.Nome;
            lblEmailDado.Text = usuario.Email;
            lblTelefoneDado.Text = usuario.Telefone;
            lblUsuarioDado.Text = usuario.Credencial.Nome;
            lblPerfilDado.Text = perfil;

            grpCadastros.Visible = true;
        }
    }
}
