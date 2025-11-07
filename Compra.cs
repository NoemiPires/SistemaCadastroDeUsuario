using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class Compra
    {
        // Propriedades
        public UInt32 Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Efetivacao { get; set; }

        //Relacionamentos
        public Cliente Cliente { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
        public List<Item> Itens { get; set; } = new List<Item>();
        public Vendedor Vendedor { get; set; }

        //Read-Only
        public Decimal CalcularTotal => CalcularTotal();


        private Decimal _comicao;
        public Decimal Comicao
        {
            get
            {
                return Comicao;
            }
            private set
            {
              _comicao = (CalcularTotalItens()*(1/100));

            }
        }
       
       

        // Fazer Métodos
        public static Decimal CalcularTotalItens()
        {
            BindingList<Item> c = new BindingList<Item>();
            c = ItemRepository.FindById();

            foreach (Item preco in c)
            {
                if (preco.CalcularTotal() != 0)
                {
                    Comicao = Comicao + preco.CalcularTotal();

                    return Comicao;

                    break;
                }

            }
        }
    }
}