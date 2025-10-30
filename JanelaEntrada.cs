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

            Credencial c1 = new Credencial();

            c1.Senha = "123456";
            c1.Gerente = true;
            c1.Nome = "JDCria";

            Usuario u1 = new Usuario();

            u1.Nome = "Giovanna";
            u1.Telefone = "349991067707";
            u1.Email = "gmss3@aluno.ifnmg.edu.br";

            u1.Credencial = c1;

            UsuarioRepository.SaveOrUpdate(u1);

        }

        public static JanelaEntrada GetInstance()
        {
            if (_instance == null)
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
            #region
            List<Credencial> c = new List<Credencial>();
            c = CredencialRepository.FindAll();

            if (txtUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            {
                lblAlerta.Visible = true;

                txtUsuario.Focus();
                txtUsuario.SelectAll();
                txtSenha.Clear();

                return;
            }

            foreach (Credencial n in c)
            {
                if (n.Nome == txtUsuario.Text)
                {
                    if (n.Senha == Credencial.ComputeSHA256(txtSenha.Text, Credencial.SALT))
                    {
                        var usuarios = UsuarioRepository.FindAll();
                        Usuario usuario = usuarios.FirstOrDefault();

                        this.Hide();

                        JanelaPrincipal.GetInstance(usuario).Show();

                        var Acesso = DateTime.Now;
                        JanelaPrincipal.GetInstance(usuario).lblAcesso.Text = $"Último Acesso: {Acesso}";
                    }

                    break;
                }
            }
            #endregion

        }


        private void txbNome_TextChanged(object sender, EventArgs e)
        {
            lblAlerta.Visible = false;
        }

        private void JanelaEntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
