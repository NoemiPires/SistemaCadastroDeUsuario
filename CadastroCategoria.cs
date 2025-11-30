using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastroDeUsuario
{
    public partial class CadastroCategoria : Form
    {
        private static CadastroCategoria? _instanceAdd;
        private static CadastroCategoria? _instanceAtt;
        private static Categoria? _cat;

        public static void Set(Categoria c)
        {
            _cat = c;
        }
        private CadastroCategoria()
        {
            
            InitializeComponent();
            if (_cat != null)
            {
                txtCategoria.Text = _cat.Nome;
            }
        }

        public static CadastroCategoria GetInstance()
        {
            if (_cat == null)
            {
                if (_instanceAdd == null || _instanceAdd.IsDisposed) _instanceAdd = new CadastroCategoria();

                return _instanceAdd;
            }
            else
            {
                if (_instanceAtt == null || _instanceAtt.IsDisposed) _instanceAtt = new CadastroCategoria();

                return _instanceAtt;
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            lblAlertaExiste.Visible = false;
            lblAlertaSucesso.Visible = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void txtCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Salvar();
        }

        public void Salvar()
        {
            // Deixando todos os alertas invisíveis
            lblAlertaExiste.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaVazio.Visible = false;

            // Verificando se a caixa de texto está vazia
            if (txtCategoria.Text.Trim() == "")
            {
                lblAlertaVazio.Visible = true;
                return;
            }

            // Verificando se a categoria já existe
            foreach (Categoria ca in CategoriaRepository.FindAll())
            {
                if (ca.Nome.ToLower() == txtCategoria.Text.ToLower())
                {
                    txtCategoria.Focus();
                    lblAlertaExiste.Visible = true;
                    return;
                }
            }

            // Criando o objeto com o dado
            Categoria c = new Categoria()
            {
                Id = _cat != null ? _cat.Id : 0,
                Nome = txtCategoria.Text.Trim()
            };

            // Salvando no banco de dados
            CategoriaRepository.SaveOrUpdate(c);
            CadastroProduto.UpdateListCategoriasSalvos();

            txtCategoria.Clear();
            txtCategoria.Focus();
            lblAlertaSucesso.Visible = true;
            ListaCategoria.GetInstance().UpdateListCategoria();
        }
    }
}
