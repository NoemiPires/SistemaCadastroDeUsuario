using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class VendedorRepository
    {
        public static void SaveOrUpdate(Vendedor vendedor)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    if (vendedor.Id == 0)
                    {
                        dbContext.Vendedores.Add(vendedor);
                    }
                    else
                    {
                        dbContext.Entry(vendedor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Vendedor? FindById(UInt32 matricula)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Vendedores.Find(matricula);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Vendedor> FindAll()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Vendedores.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Vendedor vendedor)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    dbContext.Vendedores.Remove(vendedor);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
