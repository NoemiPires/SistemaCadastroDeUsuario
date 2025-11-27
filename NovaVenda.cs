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
        public NovaVenda()
        {
            InitializeComponent();
            // LblNomeCliente vai receber o nome do cliente selecionado na janela ClienteCompra
            lblNomeCliente.Text = ClienteCompra.GetInstance().GetNomeCliente();

        }

        public static NovaVenda GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new NovaVenda();
            }
            return _instance;
        }

        private void NovaVenda_Load(object sender, EventArgs e)
        {

        }


    }
}
