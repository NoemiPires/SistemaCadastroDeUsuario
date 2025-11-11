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
    public partial class CadastrarNovosUsuarios : Form
    {
        private static CadastrarNovosUsuarios _instance;
        public CadastrarNovosUsuarios()
        {
            InitializeComponent();
        }

        public static CadastrarNovosUsuarios GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CadastrarNovosUsuarios();
            }
            return _instance;
        }

        #region Erro de Clicar Duas Vezes
        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        
    }
}
