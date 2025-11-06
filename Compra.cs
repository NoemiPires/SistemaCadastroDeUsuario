using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class Compra
    {
        [Key]
        public UInt32 Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Efetivacao { get; set; }
        //public Decimal Comicao
        //{
        //    get
        //    {

        //    }
        //    set
        //    {
        //        _comicao = value;

        //    }
        //}
        public List<Pagamento> Pagamentos { get; set; }
        public Cliente Cliente { get; set; }

        // Fazer Métodos
        //public Decimal CalcularTotal()
        //{

        //}
    }
}
