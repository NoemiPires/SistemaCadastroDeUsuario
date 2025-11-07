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
        // estado para método PodeRealizarNovaCompra() em Cliente
        public Estado Estado { get; set; }
        public Cliente Cliente { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
        public List<Item> Itens { get; set; } = new List<Item>();
        public Vendedor Vendedor { get; set; }

        //Read-Only
        private Decimal _comissao;
        public Decimal Comissao
        {
            get
            {
                return _comissao;
            }
            private set
            {
                _comissao = CalcularComissao();
            }
        }

        //Metodos

        public Decimal CalcularTotal()
        {
            List<Item> itensDaCompra = ItemRepository.FindByCompraId(this.Id);

            //o m no final diz que é monetário, reconhecido por UInt32.
            Decimal total = 0m;

            foreach (Item item in itensDaCompra)
            {
                total = total + item.CalcularTotal();
            }

            return total;
        }
        
        public Decimal CalcularComissao()
        {
            return CalcularTotal() * 0.01m;
        }
    }
}