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
using Mysqlx.Notice;

namespace Trabalho
{
    public partial class CadastroUsuario : Form
    {
        private static CadastroUsuario? _instanceAdd;
        private static CadastroUsuario? _instanceAtt;
        private static Usuario? _usu;
        public static void Set(Usuario u)
        {
            _usu = u;
        }
        private CadastroUsuario()
        {
            InitializeComponent();

            mskTelefone.Mask = "(00)00000-0000";

            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (_usu != null)
            {
                mskTelefone.Text = _usu.Telefone;
                txtEmail.Text = _usu.Email;
                txtNome.Text = _usu.Nome;
                txtUsuario.Text = _usu.Credencial.Nome;

                txtSenha.Enabled = false;
                lblSenha.Visible = false;
                grpPerfil.Visible = false;
            }

        }

        public static CadastroUsuario GetInstance()
        {
            if(_usu == null)
            {
                if (_instanceAdd == null || _instanceAdd.IsDisposed) _instanceAdd = new CadastroUsuario();

                return _instanceAdd;
            }
            else
            {
                if (_instanceAtt == null || _instanceAtt.IsDisposed) _instanceAtt = new CadastroUsuario();

                return _instanceAtt;
            }
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
                mskTelefone.SelectAll();
            }
        }

        private void mskTelefone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUsuario.Focus();
                txtUsuario.SelectAll();
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
            if (e.KeyCode == Keys.Enter) Save();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblAlertaUsuario.Visible = false;
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaEmail.Visible = false;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblAlertaUsuario.Visible = false;
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaEmail.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblAlertaUsuario.Visible = false;
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaEmail.Visible = false;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            lblAlertaUsuario.Visible = false;
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaEmail.Visible = false;
        }

        private void mskTelefone_TextChanged(object sender, EventArgs e)
        {
            lblAlertaUsuario.Visible = false;
            lblAlertaVazio.Visible = false;
            lblAlertaEmail.Visible = false;
            lblAlertaSucesso.Visible = false;
        }

        private void Save()
        {
            // Deixando todos os alertas invisíveis
            lblAlertaSucesso.Visible = false;
            lblAlertaUsuario.Visible = false;
            lblAlertaVazio.Visible = false;
            lblAlertaEmail.Visible = false;

            // Verificando se as caixas de texto estão vazias
            if (txtNome.Text.Trim() == "" || txtEmail.Text.Trim() == ""
                || mskTelefone.Text.Trim() == "()-"
                || txtUsuario.Text.Trim() == "")
            {
                lblAlertaVazio.Visible = true;
                return;
            }

            if (!mskTelefone.MaskCompleted)
            {
                lblAlertaVazio.Visible = true;
                mskTelefone.Focus();
                return;
            }

            if (!VerificarEmail(txtEmail.Text.Trim()))
            {
                txtEmail.Focus();
                txtEmail.SelectAll();
                lblAlertaEmail.Visible = true;
                return;
            }

            // Verificando se o nome de usuário já existe
            foreach (Credencial c in CredencialRepository.FindAll())
            {
                if (_usu == null)
                {
                    if (c.Nome == txtUsuario.Text)
                    {
                        lblAlertaUsuario.Visible = true;
                        txtUsuario.Focus();
                        txtUsuario.SelectAll();
                        return;
                    }
                }
                else
                {
                    if (c.Nome == txtUsuario.Text && c.Id != _usu.Id)
                    {
                        lblAlertaUsuario.Visible = true;
                        txtUsuario.Focus();
                        txtUsuario.SelectAll();
                        return;
                    }
                }
            }

            // Se for para adicionar novo usuário
            if (_usu == null)
            {
                // Verificando o perfil selecionado
                Perfil _pselecionado = Perfil.VENDEDOR;

                if (!radGerente.Checked && !radVendedor.Checked && !radOperadorCaixa.Checked)
                {
                    lblAlertaVazio.Visible = true;
                    return;
                }
                else
                {
                    if (radGerente.Checked) _pselecionado = Perfil.GERENTE;
                    else if (radVendedor.Checked) _pselecionado = Perfil.VENDEDOR;
                    else _pselecionado = Perfil.OPERADOR_CAIXA;
                }

                // Verificando se as caixas de senha está vazia
                if (txtSenha.Text.Trim() == "")
                {
                    lblAlertaVazio.Visible = true;
                    return;
                }

                // Criando os objetos com os dados
                Credencial novaCredencial = new Credencial()
                {
                    Nome = txtUsuario.Text,
                    Senha = txtSenha.Text,
                    Perfil = _pselecionado
                };

                if (_pselecionado == Perfil.VENDEDOR || _pselecionado == Perfil.GERENTE)
                {
                    Vendedor novoUsuario = new Vendedor()
                    {
                        Matricula = (UInt32)(VendedorRepository.FindAll().Count() + 1),
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Telefone = mskTelefone.Text,
                        Credencial = novaCredencial
                    };

                    // Salva no banco de dados
                    VendedorRepository.SaveOrUpdate(novoUsuario);
                    ListaUsuarios.UpdateListUsuariosWithCredencial();
                }
                else
                {
                    Usuario novoUsuario = new Usuario()
                    {
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Telefone = mskTelefone.Text,
                        Credencial = novaCredencial
                    };

                    // Salva no banco de dados
                    UsuarioRepository.SaveOrUpdate(novoUsuario);
                    ListaUsuarios.UpdateListUsuariosWithCredencial();
                }

                // Limpa as caixas de texto
                txtSenha.Clear();
                txtUsuario.Clear();
                mskTelefone.Clear();
                txtEmail.Clear();
                txtNome.Clear();
                txtNome.Focus();
            }
            else
            {
                // Criando os objetos com os dados
                Credencial novaCredencial = new Credencial()
                {
                    Id = _usu.Credencial.Id,
                    Nome = txtUsuario.Text,
                };

                if (_usu.Credencial.Perfil == Perfil.VENDEDOR || _usu.Credencial.Perfil == Perfil.GERENTE)
                {
                    Vendedor novoUsuario = new Vendedor()
                    {
                        Matricula = VendedorRepository.FindById(_usu.Id)!.Matricula,
                        Id = _usu.Id,
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Telefone = mskTelefone.Text,
                        Credencial = novaCredencial
                    };

                    // Salva no banco de dados
                    CredencialRepository.SaveOrUpdate(novaCredencial);
                    VendedorRepository.SaveOrUpdate(novoUsuario);
                    ListaUsuarios.UpdateListUsuariosWithCredencial();
                }
                else
                {
                    Usuario novoUsuario = new Usuario()
                    {
                        Id = _usu.Id,
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Telefone = mskTelefone.Text,
                        Credencial = novaCredencial
                    };

                    // Salva no banco de dados
                    CredencialRepository.SaveOrUpdate(novaCredencial);
                    UsuarioRepository.SaveOrUpdate(novoUsuario);
                    ListaUsuarios.UpdateListUsuariosWithCredencial();
                }

                lblAlertaSucesso.Visible = true;
            }
        }

        private Boolean VerificarEmail(String email)
        {
            String emailpadrao = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|net|org|edu|gov|mil|int|info|biz|io|dev|app|com\.br|net\.br|org\.br|edu\.br|gov\.br)$";

            Regex r = new Regex(emailpadrao);
            return r.IsMatch(email);
        }

        private void CadastroUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            _usu = null;
        }
    }
}
