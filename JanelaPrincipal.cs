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
        // Change the access modifier of lblAcesso from private to public

        private JanelaPrincipal(Usuario usuario)
        {
            InitializeComponent();

            Text = $"Sistema de Cadastro de Usuários - {usuario.Nome}";

            mnuCadastroUsuario.Enabled = usuario.Credencial.Gerente;

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

        //private void mnuAjudaSobre_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Sistema de Cadastro de Usuários\nVersão 1.0\nDesenvolvido por Noemi e Mellany");
        //}

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarNovosUsuarios cadastrarNovosUsuarios = CadastrarNovosUsuarios.GetInstance();
            cadastrarNovosUsuarios.MdiParent = this;
            cadastrarNovosUsuarios.BringToFront();
            cadastrarNovosUsuarios.Show();
        }

        //private void mnuArquivoSair_Click(object sender, EventArgs e)
        //{

        //    JanelaEntrada.GetInstance().Show();
        //    JanelaEntrada.GetInstance().LimparCampos();
        //    Close();

        //}
        #region
        private void lblAcesso_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void JanelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
        #endregion

        private void mnuArquivoSair_Click_1(object sender, EventArgs e)
        {


            JanelaEntrada.GetInstance().Show();
            JanelaEntrada.GetInstance().LimparCampos();
            Close();

        }

        private void mnuAjudaSobre_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Cadastro de Usuários\nVersão 1.0\nDesenvolvido por Noemi e Mellany");
        }
    }
}
