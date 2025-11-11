using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class Vendedor
    {
        [ForeignKey("Matricula")]
        public UInt32 Id { get; set; }
        public String Nome { get; set; }

        public List<Compra> Vendas { get; set; }
    }
}
