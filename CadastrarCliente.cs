using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace SistemaCadastroDeUsuario
{
    public partial class CadastrarCliente : Form
    {
        private static CadastrarCliente _instance;
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        public static CadastrarCliente GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CadastrarCliente();
            }
            return _instance;
        }



       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;

            ClienteRepository.SaveOrUpdate(cliente);

            lblAlertaClienteCadastrado.Visible = true;

            txtNome.Clear();
            txtCpf.Clear();
            txtNome.Focus();

        }
    }
}
