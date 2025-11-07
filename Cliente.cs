using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class Cliente
    {
        // Propriedades
        public UInt32 Id { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }

        //relacionamento
        public List<Compra> Compras { get; set; }

        // Métodos para conferir
        public Boolean PodeRealizarNovaCompra()
        {
           foreach (Compra compra in Compras)
           {
                if (compra.Estado == Estado.PENDENTE)
                {
                    return false;

                    break;
                }
           }

           return true;
        }
    }
}
