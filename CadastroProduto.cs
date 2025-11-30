using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastroDeUsuario
{
    public partial class CadastroProduto : Form
    {
        private static CadastroProduto? _instanceAdd;
        private static CadastroProduto? _instanceAtt;
        private Boolean _isAdd = false;
        private static Produto? _produtoAtualizar = null;

        #region DataSource
        private static BindingList<Categoria>? CategoriasSalvas;
        public static void UpdateListCategoriasSalvos()
        {
            List<Categoria> lista = CategoriaRepository.FindAll();

            // Se não tem nada na lista
            if (CategoriasSalvas == null) CategoriasSalvas = new BindingList<Categoria>();

            // Limpa a lista antiga
            CategoriasSalvas.Clear();

            // Adiciona o "Título"
            CategoriasSalvas.Add(new Categoria() { Nome = "Selecionar categoria" });

            // Adiciona os itens atualizados
            foreach (Categoria u in lista) CategoriasSalvas.Add(u);
        }
        public static BindingList<Categoria> GetListCategoriasSalvos()
        {
            UpdateListCategoriasSalvos();

            return CategoriasSalvas!;
        }
        private CadastroProduto(Boolean add)
        {
            InitializeComponent();
            btnAcao.Text = add ? "Adicionar" : "Atualizar";
            Text = add ? "Adicionar Produtos" : "Atualizar Produtos";

            _isAdd = add;

            cboCategoria.DataSource = GetListCategoriasSalvos();
            cboCategoria.DisplayMember = "Nome";

            if (add)
            {
                txtDescricao.Clear();
                txtQuantidade.Clear();
                txtValor.Text = "R$ 0,00";
                txtEstoqueMinimo.Text = "10";
                cboCategoria.SelectedIndex = 0;
                chkEstado.Checked = true;
            }
            else
            {
                UInt16 _num = 0;

                foreach (Categoria c in CategoriasSalvas!)
                {
                    if (c.Id == _produtoAtualizar!.Categoria!.Id) break;

                    _num += 1;
                }

                txtDescricao.Text = _produtoAtualizar!.Nome;
                txtQuantidade.Text = _produtoAtualizar.Estoque.ToString();
                txtValor.Text = _produtoAtualizar.Preco.ToString("C2");
                txtEstoqueMinimo.Text = _produtoAtualizar.EstoqueMinimo.ToString();
                cboCategoria.SelectedIndex = (int)_num;
                chkEstado.Checked = _produtoAtualizar.Ativo;
            }
            txtValor.TextChanged += txtValor_TextChanged!;
            txtValor.KeyPress += txtValor_KeyPress!;
        }

        public static void Set(Produto produto)
        {
            _produtoAtualizar = produto;
        }

        public static CadastroProduto GetInstance(Boolean add)
        {
            if (add)
            {
                if (_instanceAdd == null || _instanceAdd.IsDisposed)
                    _instanceAdd = new CadastroProduto(add);

                return _instanceAdd;
            }
            else
            {
                if (_instanceAtt == null || _instanceAtt.IsDisposed)
                    _instanceAtt = new CadastroProduto(add);

                return _instanceAtt;
            }
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            // Deixando todos os alertas invisíveis
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaProduto.Visible = false;
            lblAvisoEstoqueMinimo.Visible = false;
            lblAlertaValor.Visible = false;

            // Verificando se as caixas de texto estão vazias
            if (txtDescricao.Text.Trim() == "" || txtQuantidade.Text.Trim() == ""
                || txtValor.Text.Trim() == "" || cboCategoria.SelectedIndex <= 0 || txtEstoqueMinimo.Text.Trim() == "")
            {
                lblAlertaVazio.Visible = true;
                return;
            }

            // Se for pra adicionar checa se tem nome duplicado
            if (_isAdd)
            {
                foreach (Produto pr in ProdutoRepository.FindAll())
                {
                    if (pr.Nome!.ToLower() == txtDescricao.Text.ToLower())
                    {
                        lblAlertaProduto.Visible = true;
                        return;
                    }
                }
            }

            // Verificando se o estoque mínimo é maior que o estoque atual
            if (txtEstoqueMinimo.Text.Trim() != "" && txtQuantidade.Text.Trim() != "")
            {
                UInt32 estoqueMinimo = UInt32.Parse(txtEstoqueMinimo.Text.Trim());
                UInt32 estoqueAtual = UInt32.Parse(txtQuantidade.Text.Trim());
                if (estoqueMinimo > estoqueAtual)
                {
                    lblAvisoEstoqueMinimo.Visible = true;
                    return;
                }
            }

            if (txtValor.Text.Trim() == "R$0,00")
            {
                lblAlertaValor.Visible = true;
                return;
            }

            // Criando o objeto com os dados
            Produto p = new Produto()
            {
                Id = _isAdd ? 0 : _produtoAtualizar!.Id,
                Nome = txtDescricao.Text.Trim(),
                Estoque = UInt32.Parse(txtQuantidade.Text.Trim()),
                Preco = ParsePreco(txtValor.Text.Trim()),
                Categoria = cboCategoria.SelectedItem as Categoria,
                EstoqueMinimo = UInt32.Parse(txtEstoqueMinimo.Text.Trim()),
                Ativo = chkEstado.Checked
            };

            // Salva no banco de dados
            ProdutoRepository.SaveOrUpdate(p);

            // Limpa as caixas de texto
            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            txtDescricao.Focus();
            cboCategoria.SelectedIndex = 0;
            chkEstado.Checked = true;
            txtEstoqueMinimo.Text = "10";

            lblAlertaSucesso.Visible = true;
            ListaProdutos.GetInstance().AtualizarGrade();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            CadastroCategoria janela = CadastroCategoria.GetInstance();
            janela.ShowDialog(this);
            janela.BringToFront();
            janela.Focus();
        }


        private Boolean travarDescricao = false;
        private const int descricaoMax = 40;
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaProduto.Visible = false;
            lblAvisoEstoqueMinimo.Visible = false;
            lblAlertaValor.Visible = false;

            if (travarDescricao) return;

            travarDescricao = true;

            TextBox t = (TextBox)sender;

            String texto = Regex.Replace(t.Text, @"[^ \p{L}\d]", "");

            if (texto.Length > descricaoMax)
            {
                texto = texto.Substring(0, descricaoMax);
            }

            if (t.Text != texto)
            {
                t.Text = texto;
                t.SelectionStart = t.Text.Length;
            }

            travarDescricao = false;
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaProduto.Visible = false;
            lblAvisoEstoqueMinimo.Visible = false;
            lblAlertaValor.Visible = false;
        }

        private decimal ParsePreco(String input)
        {
            if (String.IsNullOrWhiteSpace(input)) return 0m;

            String s = input.Trim()
                            .Replace("R$", "", StringComparison.OrdinalIgnoreCase)
                            .Replace("$", "")
                            .Replace(" ", "");

            var pt = CultureInfo.GetCultureInfo("pt-BR");
            if (Decimal.TryParse(s, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.AllowCurrencySymbol, pt, out var valor))
                return valor;

            // Se falhar, devolve 0 (mantém comportamento simples). Você pode validar e mostrar erro ao usuário se preferir.
            return 0m;
        }

        private Boolean travar = false;

        private const int digitoMax = 8;
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaProduto.Visible = false;
            lblAvisoEstoqueMinimo.Visible = false;
            lblAlertaValor.Visible = false;

            if (travar) return;

            travar = true;

            TextBox t = (TextBox)sender;

            String numeros = System.Text.RegularExpressions.Regex.Replace(t.Text, @"[^\d]", "");

            if (numeros.Length > digitoMax)
            {
                numeros = numeros.Substring(0, digitoMax);
            }


            if (numeros.Length == 0)
            {
                numeros = "0";
            }

            Decimal valor = Decimal.Parse(numeros) / 100m;

            t.Text = valor.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));

            t.SelectionStart = t.Text.Length;

            travar = false;

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }
        }

        private Boolean travarQuantidade = false;

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaProduto.Visible = false;
            lblAvisoEstoqueMinimo.Visible = false;
            lblAlertaValor.Visible = false;

            if (travarQuantidade) return;

            travarQuantidade = true;

            TextBox t = (TextBox)sender;

            String digitos = System.Text.RegularExpressions.Regex.Replace(t.Text, @"[^\d]", "");

            if (digitos.Length == 0)
            {
                digitos = "";
            }

            if (digitos.Length > digitoMax)
            {
                digitos = digitos.Substring(0, digitoMax);
            }

            t.Text = digitos;
            t.SelectionStart = t.Text.Length;

            travarQuantidade = false;

        }

        private Boolean travarEstoqueMinimo = false;

        private void txtEstoqueMinimo_TextChanged(object sender, EventArgs e)
        {
            lblAlertaVazio.Visible = false;
            lblAlertaSucesso.Visible = false;
            lblAlertaProduto.Visible = false;
            lblAvisoEstoqueMinimo.Visible = false;
            lblAlertaValor.Visible = false;

            if (travarEstoqueMinimo) return;

            travarEstoqueMinimo = true;

            TextBox t = (TextBox)sender;

            String digitos = System.Text.RegularExpressions.Regex.Replace(t.Text, @"[^\d]", "");

            if (digitos.Length == 0)
            {
                digitos = "";
            }

            if (digitos.Length > digitoMax)
            {
                digitos = digitos.Substring(0, digitoMax);
            }

            t.Text = digitos;
            t.SelectionStart = t.Text.Length;

            travarEstoqueMinimo = false;

        }

        private void txtDescricao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuantidade.Focus();
                txtQuantidade.SelectAll();
            }
        }

        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValor.Focus();
                txtValor.SelectAll();
            }
        }

        private void txtEstoqueMinimo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcao.Focus();
            }
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEstoqueMinimo.Focus();
                txtEstoqueMinimo.SelectAll();
            }
        }
    }
}