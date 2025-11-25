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
    // Total de vendas no período selecionado
    public partial class RelatorioTotalPeriodo : Form
    {
        private static RelatorioTotalPeriodo _instance;
        public RelatorioTotalPeriodo(DateTime data)
        {
            InitializeComponent();
            List<Compra> compras = new List<Compra>();

            compras = CompraRepository.FindByData(data);

            lstPeriodo.DisplayMember = "inicio"; 
            lstPeriodo.Items.AddRange(compras.ToArray());
            lstPeriodo.SelectedIndex = 0;
        }

        public static RelatorioTotalPeriodo GetInstance(DateTime data)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new RelatorioTotalPeriodo(data);
            }
            return _instance;
        }


        private void lstPeriodo_Click(object sender, EventArgs e)
        {
            Compra? compra = (Compra?)lstPeriodo.SelectedItem;
            if (compra == null)
            {
                return;
            }

            // Additional item-click behavior can be added here if needed.
        }
    }
}
