using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class CompraRepository
    {
        public static void SaveOrUpdate(Compra compra)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    if (compra.Id == 0)
                    {
                        dbContext.Compras.Add
                    }
                }
            }
        }




    }

}
