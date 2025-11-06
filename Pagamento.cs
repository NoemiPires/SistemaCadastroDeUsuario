using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class Pagamento
    {
        public UInt32 Id { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        private Decimal? _multaAtraso;
        //public Decimal MultaAtraso
        //{
        //    get
        //    {

        //    }
        //    set
        //    {
        //        _multaAtraso = value;


        //    }
        //}

        //public Decimal CalcularMulta()
        //{
        //    DateTime.Now
        //        while (
        //}
    }
}
