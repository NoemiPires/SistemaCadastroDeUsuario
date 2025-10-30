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
        private JanelaPrincipal()
        {
            InitializeComponent();
            
            //Text = $"Sistema de Cadastro de Usuários - Bem vindo, {usuario.Nome}";
            //mnuCadastroUsuario.Enabled = usuario.Credencial.Gerente;
        }
      

        public static JanelaPrincipal GetInstance()
        {
            if (_instance == null)
            {
                _instance = new JanelaPrincipal();
            }
            return _instance;

        }


        private void mnuAjudaSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Cadastro de Usuários\nVersão 1.0\nDesenvolvido por Noemi e Mellany");
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarNovosUsuarios cadastrarNovosUsuarios = new CadastrarNovosUsuarios();
            cadastrarNovosUsuarios.MdiParent = this;
            cadastrarNovosUsuarios.WindowState = FormWindowState.Normal;
            cadastrarNovosUsuarios.BringToFront();
            cadastrarNovosUsuarios.Show();
        }

        private void mnuArquivoSair_Click(object sender, EventArgs e)
        {
           
            JanelaEntrada.GetInstance().Show();
            JanelaEntrada.GetInstance().LimparCampos();
            Close();

        }
    }
}
