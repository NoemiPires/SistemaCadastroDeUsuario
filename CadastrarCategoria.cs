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

        //salvar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Save();
        }

        // salvar ao pressionar enter
        private void txtCategoriaNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }
        private void Save()
        {
            // Deixando todos os alertas invisíveis
            lblAlertaCategoriaJaExistente.Visible = false;
            lblAlertaCadastroEfetuado.Visible = false;
            lblAlertaCampoVazio.Visible = false;

            // Verificando se a caixa de texto está vazia
            if (txtCategoriaNome.Text.Trim() == "")
            {
                lblAlertaCampoVazio.Visible = true;
                return;
            }

            // Verificando se a categoria já existe
            foreach (Categoria ca in CategoriaRepository.FindAll())
            {
                if (ca.Nome.ToLower() == txtCategoriaNome.Text.ToLower())
                {
                    txtCategoriaNome.Focus();
                    lblAlertaCategoriaJaExistente.Visible = true;
                    return;
                }
            }

            // Criando o objeto com o dado
            Categoria c = new Categoria()
            {
                Id = _categoria != null ? _categoria.Id : 0,
                Nome = txtCategoriaNome.Text.Trim()
            };

            // Salvando no banco de dados
            CategoriaRepository.SaveOrUpdate(c);
            CadastrarProduto.UpdateListCategoriasSalvos();

            txtCategoriaNome.Clear();
            txtCategoriaNome.Focus();
            lblAlertaCadastroEfetuado.Visible = true;
        }
        #endregion

        // Avisos
        private void txtCategoriaNome_TextChanged(object sender, EventArgs e)
        {
            lblAlertaCategoriaJaExistente.Visible = false;
            lblAlertaCadastroEfetuado.Visible = false;
        }
    }
}
