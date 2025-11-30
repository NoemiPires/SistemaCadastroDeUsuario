using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace SistemaCadastroDeUsuario
{
    public partial class CadastrarCliente : Form
    {
        private static CadastrarCliente _instance;
        private static Cliente? _clienteAtualizar;
        public CadastrarCliente()
        {
            InitializeComponent();

            if (_clienteAtualizar != null)
            {
                txtNome.Text = _clienteAtualizar.Nome;
                txtEmail.Text = _clienteAtualizar.Email;
                mskCpf.Text = _clienteAtualizar.Cpf;
            }
        }

        public static void SetClienteToUpdate(Cliente cliente)
        {
            _clienteAtualizar = cliente;
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
            lblAlertaCamposObrigatorios.Visible = false;
            lblAlertaClienteCadastrado.Visible = false;
            lblAlertaCpfInvalido.Visible = false;
            lblAlertaEmailInvalido.Visible = false;

            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            // Verificando se os campos estão preenchidos
            if (txtNome.Text.Trim() == "" || txtEmail.Text.Trim() == ""
                || mskCpf.Text.Trim() == "")
            {
                lblAlertaCamposObrigatorios.Visible = true;
                return;
            }

            if (!mskCpf.MaskCompleted)
            {
                mskCpf.Focus();
                lblAlertaCamposObrigatorios.Visible = true;
                return;
            }
            mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            // Verificando se o cpf do cliente já existe
            foreach (Cliente c in ClienteRepository.FindAll())
            {
                if (c.Cpf == mskCpf.Text.Trim())
                {
                    mskCpf.Focus();
                    mskCpf.SelectAll();
                    lblAlertaCpfInvalido.Visible = true;
                    return;
                }

            }

            if (!ValidarEmail(txtEmail.Text.Trim()))
            {
                txtEmail.Focus();
                txtEmail.SelectAll();
                lblAlertaEmailInvalido.Visible = true;
                return;
            }

            if (_clienteAtualizar != null)
            {
                _clienteAtualizar.Nome = txtNome.Text.Trim();
                _clienteAtualizar.Email = txtEmail.Text.Trim();
                _clienteAtualizar.Cpf = mskCpf.Text.Trim();
                ClienteRepository.SaveOrUpdate(_clienteAtualizar);
                ListaClientes.GetInstance(false).UpdateListClientes();
                _clienteAtualizar = null;
                lblAlertaClienteCadastrado.Visible = true;
                return;
            }

            Cliente cliente = new Cliente()
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Cpf = mskCpf.Text.Trim()
            };

            ClienteRepository.SaveOrUpdate(cliente);
            ListaClientes.GetInstance(false).UpdateListClientes();

            txtNome.Clear();
            txtNome.Focus();
            txtEmail.Clear();
            mskCpf.Clear();

            lblAlertaClienteCadastrado.Visible = true;

        }

        private Boolean ValidarEmail(String email)
        {
            String emailpadrao = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|net|org|edu|gov|mil|int|info|biz|io|dev|app|com\.br|net\.br|org\.br|edu\.br|gov\.br)$";

            Regex r = new Regex(emailpadrao);
            return r.IsMatch(email);
        }

    }
}
}
