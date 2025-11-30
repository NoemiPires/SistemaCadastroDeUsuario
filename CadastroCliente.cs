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

namespace SistemaCadastroDeUsuario
{
    public partial class CadastroCliente : Form
    {
        private static CadastroCliente? _instance;
        private static Cliente? _clienteAtualizar;
        private CadastroCliente()
        {
            InitializeComponent();

            if (_clienteAtualizar != null)
            {
                txtNome.Text = _clienteAtualizar.Nome;
                txtEmail.Text = _clienteAtualizar.Email;
                mskCpf.Text = _clienteAtualizar.Cpf;
            }

        }

        public static void Set(Cliente c)
        {
            _clienteAtualizar = c;
        }
        public static CadastroCliente GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Ca();
            }
            return _instance;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaCliente.Visible = false;
            lblAlertaEmail.Visible = false;

            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            // Verificando se os campos estão preenchidos
            if (txtNome.Text.Trim() == "" || txtEmail.Text.Trim() == ""
                || mskCpf.Text.Trim() == "")
            {
                lblAlertaVazio.Visible = true;
                return;
            }

            if (!mskCpf.MaskCompleted)
            {
                mskCpf.Focus();
                lblAlertaVazio.Visible = true;
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
                    lblAlertaCliente.Visible = true;
                    return;
                }
            }

            if (!ValidarEmail(txtEmail.Text.Trim()))
            {
                txtEmail.Focus();
                txtEmail.SelectAll();
                lblAlertaEmail.Visible = true;
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
                lblAlertaSucesso.Visible = true;
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

            lblAlertaSucesso.Visible = true;

        }

        private Boolean ValidarEmail(String email)
        {
            String emailpadrao = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|net|org|edu|gov|mil|int|info|biz|io|dev|app|com\.br|net\.br|org\.br|edu\.br|gov\.br)$";

            Regex r = new Regex(emailpadrao);
            return r.IsMatch(email);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaCliente.Visible = false;
            lblAlertaEmail.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaCliente.Visible = false;
            lblAlertaEmail.Visible = false;
        }

        private void mskCpf_TextChanged(object sender, EventArgs e)
        {
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaCliente.Visible = false;
            lblAlertaEmail.Visible = false;
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
                txtEmail.SelectAll();
            }
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mskCpf.Focus();
                mskCpf.SelectAll();
            }
        }

        private void mskCpf_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Salvar();
            }
        }
    }
}
