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
        public UsuariosCadastrados()
        {
            InitializeComponent();
        }

        public static UsuariosCadastrados GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UsuariosCadastrados();
            }
            return _instance;
        }

        public void AtualizarListaUsuarios(Usuario usuario)
        {
            // Lógica para atualizar a lista de usuários cadastrados
            var usuarios = UsuarioRepository.FindAll();
            ListaUsuarios.DataSource = usuarios;
        }

    }
}
