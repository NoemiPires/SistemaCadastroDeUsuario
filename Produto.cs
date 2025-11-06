using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class Produto
    {
        public UInt32 Id { get; set; }
        public String Nome { get; set; }
        public Decimal Preco { get; set; }
        public UInt32 Estoque { get; set; }
        public UInt32 EstoqueMinimo = 10;
        public Boolean Ativo { get; set; }
    }
}
