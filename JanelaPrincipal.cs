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
    public partial class JanelaPrincipal : Form
    {
        private static JanelaPrincipal _instance;

        private Usuario _usuario;
        // Change the access modifier of lblAcesso from private to public

        private JanelaPrincipal(Usuario usuario)
        {
            InitializeComponent();

            Text = $"Sistema de Cadastro de Usuários - {usuario.Nome}";

            mnuCadastroUsuario.Enabled = usuario.Credencial.Gerente;

            _usuario = usuario;

            staBarraEstadoUltimoAcesso.Text = "Último acesso: " + usuario.Credencial.UltimoAcesso;

            if (usuario.Credencial.UltimoAcesso == DateTime.MinValue)
            {
                staBarraEstadoUltimoAcesso.Visible = false;
            }
        }

        public static JanelaPrincipal GetInstance(Usuario usuario)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JanelaPrincipal(usuario);
            }
            return _instance;

        }


        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarNovosUsuarios cadastrarNovosUsuarios = CadastrarNovosUsuarios.GetInstance();
            cadastrarNovosUsuarios.MdiParent = this;
            cadastrarNovosUsuarios.BringToFront();
            cadastrarNovosUsuarios.Show();
        }

        #region
        private void lblAcesso_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void JanelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            _usuario.Credencial.UltimoAcesso = DateTime.Now;
            UsuarioRepository.SaveOrUpdate(_usuario);

            JanelaEntrada.GetInstance().Show();
            JanelaEntrada.GetInstance().LimparCampos();
        }
        #endregion

        private void mnuArquivoSair_Click_1(object sender, EventArgs e)
        {
            _usuario.Credencial.UltimoAcesso = DateTime.Now;
            UsuarioRepository.SaveOrUpdate(_usuario);

            JanelaEntrada.GetInstance().Show();
            JanelaEntrada.GetInstance().LimparCampos();
            Close();

        }

        private void mnuAjudaSobre_Click_1(object sender, EventArgs e)
        {
           Sobre sobre = Sobre.GetInstance();
            sobre.MdiParent = this;
            sobre.WindowState = FormWindowState.Normal;
            sobre.Show();
        }
    }
}
