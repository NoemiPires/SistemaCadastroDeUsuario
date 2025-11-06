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
        
        public UInt32 Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Efetivacao { get; set; }
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
        public List<Pagamento> Pagamentos { get; set; }
        public Cliente Cliente { get; set; }

        // Fazer Métodos
        public Decimal CalcularTotalItens()
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