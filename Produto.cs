using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Boolean Ativo { get; set; }

        [ForeignKey("categoria_id")]
        public Categoria Categoria { get; set; }

        // Metodo para atualizar o estoque assim que uma compra for realizada
        public void AtualizarEstoque(UInt32 quantidadeVendida)
        {
            if (quantidadeVendida > Estoque)
            {
                throw new InvalidOperationException("Quantidade vendida excede o estoque disponível.");
            }
            Estoque -= quantidadeVendida;
        }

    }
}
