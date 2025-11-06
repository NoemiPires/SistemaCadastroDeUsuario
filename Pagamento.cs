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
        
        private Decimal _multaAtraso;                   

        public Decimal MultaAtraso
        {
            get
            {
                return CalcularMulta();
            }
            set
            {
                _multaAtraso = value;
            }
        }



        public decimal CalcularMulta()
        {
           
            if (DataPagamento > Vencimento)
            {
                TimeSpan atraso = DataPagamento - Vencimento;
                int mesesAtraso = (atraso.Days / 30);
                return mesesAtraso * 0.02m;
            }

            return 0;
        }
    }
}
