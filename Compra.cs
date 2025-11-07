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
        public Decimal Comicao
        {
            get
            {
                return CalcularComicao()
            }
            set
            {

            }
        }

        //Metodos

        public Decimal CalcularTotal()
        {
            List<Item> itensDaCompra = ItemRepository.FindByCompraId(this.Id);

            Decimal total = 0;

            foreach (Item item in itensDaCompra)
            {
                total += item.CalcularTotal();
            }

            return total;
        }
        
        public Decimal CalcularComissao()
        {
            return CalcularTotal() * 1 / 100;
        }
    }
}