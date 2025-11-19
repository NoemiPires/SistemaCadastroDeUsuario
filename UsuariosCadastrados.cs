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
    public partial class UsuariosCadastrados : Form
    {
        private static UsuariosCadastrados _instance;
        private UsuariosCadastrados()
        {
            InitializeComponent();

            List<Usuario> usuarios = new List<Usuario>();
            usuarios = UsuarioRepository.FindAllWithCredencial();

            lstUsuarios.Items.AddRange(usuarios.ToArray());
        }

        public static UsuariosCadastrados GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new UsuariosCadastrados();
            }
            return _instance;
        }

        private void lstUsuarios_Click(object sender, EventArgs e)
        {
            Usuario? usuario = (Usuario?)lstUsuarios.SelectedItem;

            if (usuario == null)
            {
                return;
            }

            String? perfil = usuario.Credencial.Tipo.ToString();

            if (usuario.Credencial.UltimoAcesso == DateTime.MinValue)
            {
                lblUltimoAcessoDado.Text = "Usuário não fez acesso!";
            }
            else
            {
                String ultacess = usuario.Credencial.UltimoAcesso.ToString("dd/MM/yyyy HH:mm");
                lblUltimoAcessoDado.Text = ultacess;
            }

            lblNomeDado.Text = usuario.Nome;
            lblEmailDado.Text = usuario.Email;
            lblTelefoneDado.Text = usuario.Telefone;
            lblUsuarioDado.Text = usuario.Credencial.Nome;
            lblPerfilDado.Text = perfil;

            grpCadastros.Visible = true;
        }

        public override string ToString()
        {
            return lblNome.Text;
        }

        //public void AtualizarListaUsuarios(Usuario usuario)
        //{
        //    // Lógica para atualizar a lista de usuários cadastrados
        //    var usuarios = UsuarioRepository.FindAll();
        //    lstUsuarios.DataSource = usuarios;
        //}

    }
}
