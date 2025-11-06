using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class Cliente
    {
        public UInt32 Id { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }

        public List<Compra> Compras { get; set; }
        //public Boolean PodeRealizarNovaCompra()
        //{
        //   return Compras;
        //}
    }
}
