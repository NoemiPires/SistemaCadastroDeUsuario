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
        private static CadastrarCategoria _instanceAdd;
        private static CadastrarCategoria _instanceAtt;
        private static Categoria _categoria;

        public static void SetCategoriaToUpdate(Categoria categoria)
        {
            _categoria = categoria;
        }

        public CadastrarCategoria()
        {
            InitializeComponent();
            if (_categoria != null)
            {
                txtCategoriaNome.Text = _categoria.Nome;
                btnCadastrar.Text = "Atualizar";
                Text = "Atualizar Categoria";
            }
            else
            {
                btnCadastrar.Text = "Cadastrar";
                Text = "Cadastrar Categoria";
            }
        }

        public static CadastrarCategoria GetInstance()
        {
            if (_categoria == null)
            {
                if (_instanceAdd == null || _instanceAdd.IsDisposed)
                {
                    _instanceAdd = new CadastrarCategoria();

                }
                return _instanceAdd;
            }
            else
            {
                if (_instanceAdd == null || _instanceAtt.IsDisposed)
                {
                    _instanceAtt = new CadastrarCategoria();

                }
                return _instanceAtt;

            }

        }



        #region Salvar

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void txtCategoriaNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }
        private void Save()
        {

            Categoria categoria = new Categoria();
            categoria.Nome = txtCategoriaNome.Text;


            CategoriaRepository.SaveOrUpdate(categoria);

            txtCategoriaNome.Clear();
            txtCategoriaNome.Focus();

            lblAlertaCadastroEfetuado.Visible = true;

        }
        #endregion

        private void CadastrarCategoria_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void txtCategoriaNome_TextChanged(object sender, EventArgs e)
        {
            lblAlertaCategoriaJaExistente.Visible = false;
        }
    }
}
