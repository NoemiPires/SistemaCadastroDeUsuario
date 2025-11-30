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
    public partial class GerenteAutorizacao : Form
    {
        private static GerenteAutorizacao? _instance;

        private static Venda? _janelaVenda;

        private Boolean _autorizado = false;

        private GerenteAutorizacao(Venda v)
        {
            InitializeComponent();

            _janelaVenda = v;

            ConfigurarGrade();
        }

        public static GerenteAutorizacao? GetInstance(Venda v)
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new GerenteAutorizacao(v);

            return _instance;
        }

        private void ConfigurarGrade()
        {
            lsvProdutos.Columns.Add("", 20);
            lsvProdutos.Columns.Add("Código:", 54);
            lsvProdutos.Columns.Add("Nome:", 200);
            lsvProdutos.Columns.Add("Categoria:", 150);
            lsvProdutos.Columns.Add("Preço (R$):", 80);
            lsvProdutos.Columns.Add("SubTotal (R$):", 100);
            lsvProdutos.Columns.Add("Desconto (%):", 88);

            lsvProdutos.View = View.Details;
            lsvProdutos.CheckBoxes = true;
            lsvProdutos.FullRowSelect = false;
            lsvProdutos.GridLines = true;
            lsvProdutos.MultiSelect = false;

            // Evita que o usuário redimensione as colunas
            lsvProdutos.ColumnWidthChanging += LsvProdutos_ColumnWidthChanging;


            // Atualiza a grade com os itens da venda
            AtualizarGrade();
        }

        private void AtualizarGrade()
        {
            // Adicionando os itens à ListView
            lsvProdutos.Items.Clear();

            foreach (Item i in _janelaVenda!._novaCompra!.Itens!)
            {
                Produto p = ProdutoRepository.FindByIdWithCategoria(i.ProdutoId)!;

                if (i.Desconto > 0.05m)
                {
                    UInt16 desconto = (UInt16)(i.Desconto * 100);

                    ListViewItem item = new ListViewItem(new string[] {
                    "",
                    p.Id.ToString(),
                    p.Nome!,
                    p.Categoria != null ? p.Categoria.Nome!.ToString() : "Sem Categoria",
                    p.Preco.ToString("C2"),
                    i.CalcularTotal().ToString("C2"),
                    desconto.ToString()
                });

                    item.Checked = true;

                    item.Tag = p;

                    lsvProdutos.Items.Add(item);
                }
            }
        }

        private void lsvProdutos_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lsvProdutos.Columns[e.ColumnIndex].Width;
        }

        public void SetAutorizado(Boolean a)
        {
            _autorizado = a;
            AutorizarDesconto();
        }

        private void AutorizarDesconto()
        {
            if (_autorizado)
            {
                foreach (ListViewItem l in lsvProdutos.Items)
                {
                    if (!l.Checked)
                    {
                        // Pega o ID do produto
                        Produto? produto = l.Tag! as Produto;

                        // Encontra o item na compra
                        foreach (Item i in _janelaVenda!._novaCompra!.Itens!)
                        {
                            if (i.ProdutoId == produto!.Id)
                            {
                                // Remove o desconto
                                i.Desconto = 0.05m;
                                break;
                            }
                        }
                    }
                }

                _janelaVenda!.FinalizarVenda();
                Close();
            }
            else
            {
                lblAlertaInválido.Visible = true;
            }
        }
    }
}
