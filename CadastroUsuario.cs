using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastroDeUsuario
{
    public partial class CadastroUsuario : Form
    {
        private static CadastroUsuario? _instance;
        private CadastroUsuario()
        {
            InitializeComponent();
        }

        public static CadastroUsuario GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CadastroUsuario();
            }
            return _instance;
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
                mskTelefone.Focus();
                mskTelefone.Select();
            }
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
                txtSenha.SelectAll();
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblUsuarioEmUso.Visible = false;
            lblCamposObrigatorios.Visible = false;
            lblCadastroEfetuado.Visible = false;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblUsuarioEmUso.Visible = false;
            lblCamposObrigatorios.Visible = false;
            lblCadastroEfetuado.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblUsuarioEmUso.Visible = false;
            lblCamposObrigatorios.Visible = false;
            lblCadastroEfetuado.Visible = false;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            lblUsuarioEmUso.Visible = false;
            lblCamposObrigatorios.Visible = false;
            lblCadastroEfetuado.Visible = false;
        }

        private void mskTelefone_MaskChanged(object sender, EventArgs e)
        {
            lblUsuarioEmUso.Visible = false;
            lblCamposObrigatorios.Visible = false;
            lblCadastroEfetuado.Visible = false;
        }

        private void Save()
        {
            lblUsuarioEmUso.Visible = false;
            lblCamposObrigatorios.Visible = false;
            lblCadastroEfetuado.Visible = false;

            if (txtNome.Text.Trim() == ""
                || txtEmail.Text.Trim() == ""
                || mskTelefone.Text.Trim() == "()-"
                || txtUsuario.Text.Trim() == ""
                || txtSenha.Text.Trim() == "")
            {
                lblUsuarioEmUso.Visible = true;
                return;
            }

            foreach (Credencial c in CredencialRepository.FindAll())
            {
                if (c.Nome == txtUsuario.Text)
                {
                    lblUsuarioEmUso.Visible = true;
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                    return;
                }
            }

            Credencial novaCredencial = new Credencial()
            {
                Nome = txtUsuario.Text,
                Senha = txtSenha.Text,
            };

            Usuario novoUsuario = new Usuario()
            {
                Nome = txtSenha.Text,
                Email = txtEmail.Text,
                Telefone = mskTelefone.Text,
                Credencial = novaCredencial
            };

            UsuarioRepository.SaveOrUpdate(novoUsuario);

            txtSenha.Clear();
            txtUsuario.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtNome.Focus();

            lblCadastroEfetuado.Visible = true;
        }

        private void mskTelefone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUsuario.Focus();
                txtUsuario.SelectAll();
            }
        }
    }
    
}
