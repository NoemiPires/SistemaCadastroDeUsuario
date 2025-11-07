using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class Item
    {
        public UInt32 Id { get; set; }
        public UInt32 Quantidade { get; set; }
        public Decimal PrecoUnitario { get; set; }
        public Decimal Desconto { get; set; }

        // Tive que fazer referencia de compra em Itens pra criar em
        // ItemRepository: FindByCompraId pois é necessário para criar
        // Calcular total em Compra.
        public Compra Compra { get; set; }

        public Decimal CalcularTotal()
        {
            return PrecoUnitario * Quantidade - (PrecoUnitario * Quantidade * (Desconto/100));
        }
    }
}
