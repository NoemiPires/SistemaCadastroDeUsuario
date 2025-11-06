using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class ClienteRepository
    {
        public static void SaveOrUpdate(Cliente cliente)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    if (cliente.Id == 0)
                    {
                        dbContext.Clientes.Add(cliente);
                    }
                    else
                    {
                        dbContext.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        public static Cliente? FindById(UInt32 id)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Clientes.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
