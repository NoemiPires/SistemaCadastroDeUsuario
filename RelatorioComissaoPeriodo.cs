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
    public partial class RelatorioComissaoPeriodo : Form
    {
        private static RelatorioComissaoPeriodo _instance;
        public RelatorioComissaoPeriodo(UInt32 vendedorId)
        {
            InitializeComponent();

            lstVendedores.DisplayMember = "NomeCompleto";
            List<Usuario> usuarios = UsuarioRepository.FindNomeByTipoVendedor();
            lstVendedores.Items.AddRange(usuarios.ToArray());

            lstPeriodo.DisplayMember = "Inicio";
            List<DateTime> datas = CompraRepository.FindDatasByVendedorId(vendedorId);
            lstPeriodo.Items.AddRange(datas.Cast<object>().ToArray());


        }
        public static RelatorioComissaoPeriodo GetInstance(UInt32 vendedorId)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new RelatorioComissaoPeriodo(vendedorId);
            }
            return _instance;
        }

        // Depois de selecionar o vendedor e o periodo,
        // mostrar a comissao total do vendedor no periodo selecionado
        private void lstVendedores_Click(object sender, EventArgs e)
        {
            if (lstVendedores.SelectedItem != null && lstPeriodo.SelectedItem != null)
            {
                Usuario vendedorSelecionado = (Usuario)lstVendedores.SelectedItem;
                DateTime periodoSelecionado = (DateTime)lstPeriodo.SelectedItem;
                Decimal comissaoTotal = CompraRepository.SumComissoesByVendedorIdAndDate((UInt32)vendedorSelecionado.Id, periodoSelecionado);
                lblComissao.Text = $"Comissão Total: {comissaoTotal:C}";
            }
        }
    }
}
