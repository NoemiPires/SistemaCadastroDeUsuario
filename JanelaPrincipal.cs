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
        private JanelaPrincipal(Usuario usuario)
        {
            InitializeComponent();
            Text = $"Bem vindo {usuario.Nome}";
        }

        public static JanelaPrincipal GetInstance(Usuario usuario)
        {
            if (_instance == null)
            {
                _instance = new JanelaPrincipal(usuario);
            }
            return _instance;
        }
    }
}
