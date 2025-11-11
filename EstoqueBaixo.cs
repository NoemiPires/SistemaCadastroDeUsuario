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
    public partial class EstoqueBaixo : Form
    {
        private static EstoqueBaixo _instance;
        public EstoqueBaixo()
        {
            InitializeComponent();
            lstEstoqueProdutos.DataSource = ProdutoRepository.FindByEstoqueMinimo();
        }

        public static EstoqueBaixo GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new EstoqueBaixo();
            }
            return _instance;
        }

    }
}
