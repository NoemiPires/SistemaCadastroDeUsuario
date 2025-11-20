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
    public partial class CadastrarCategoria : Form
    {
        private static CadastrarCategoria _instance;
        public CadastrarCategoria()
        {
            InitializeComponent();
        }

        public static CadastrarCategoria GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CadastrarCategoria();
            }
            return _instance;
        }
        #region Salvar
        private void Save()
        {
            Categoria categoria = new Categoria();
            categoria.Id = UInt32.Parse(txtId.Text);
            categoria.Nome = txtCategoriaNome.Text;
            CategoriaRepository.SaveOrUpdate(categoria);
            txtCategoriaNome.Clear();
            txtCategoriaNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Save();
        }
        #endregion
    }
}
