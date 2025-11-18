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
    public partial class VendasCadastradas : Form
    {
        private static VendasCadastradas _instance;

        public VendasCadastradas()
        {
            InitializeComponent();
        }

        public static VendasCadastradas GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new VendasCadastradas();
            }
            return _instance;
        }
    }
}
