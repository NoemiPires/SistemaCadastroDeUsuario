using System.Diagnostics.Eventing.Reader;
using Google.Protobuf.WellKnownTypes;

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
                        this.Hide();

                        JanelaPrincipal.GetInstance().Show();
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

      
    }
}
