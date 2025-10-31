using System.Diagnostics.Eventing.Reader;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;

namespace SistemaCadastroDeUsuario
{
    public partial class JanelaEntrada : Form
    {
        private static JanelaEntrada _instance;
        private JanelaEntrada()
        {
            InitializeComponent();
        }

        public static JanelaEntrada GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanelaEntrada();
            }
            return _instance;
        }

        public void LimparCampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        #region Erro
        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }


        private void txbNome_TextChanged(object sender, EventArgs e)
        {
            lblAlerta.Visible = false;
        }

        private void JanelaEntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                Entrar();
            }
        }

        private void Entrar()
        {
            List<Usuario> c = new List<Usuario>();
            c = UsuarioRepository.FindAllWithCredencial();

            if (txtUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            {
                lblAlerta.Visible = true;

                txtUsuario.Focus();
                txtUsuario.SelectAll();
                txtSenha.Clear();

                return;
            }

            foreach (Usuario n in c)
            {
                if (n.Credencial.Nome == txtUsuario.Text)
                {
                    if (n.Credencial.Senha == Credencial.ComputeSHA256(txtSenha.Text, Credencial.SALT))
                    {

                        Hide();

                        JanelaPrincipal.GetInstance(n).Show();
                    }

                    break;
                }
            }
        }
    }
}
