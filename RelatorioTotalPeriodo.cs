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
    public partial class RelatorioTotalPeriodo : Form
    {
        private static RelatorioTotalPeriodo _instance;
        public RelatorioTotalPeriodo()
        {
            InitializeComponent();
        }

        public static RelatorioTotalPeriodo GetInstance()
        { 
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new RelatorioTotalPeriodo();
            }
            return _instance;
        }
    }
}
