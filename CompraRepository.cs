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
                        dbContext.Compras.Add(compra);
                    }
                    else 
                    {
                        dbContext.Entry(compra).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Compra? FindById(UInt32 id)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Compras.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Compra> FindByClienteId(UInt32 clienteId)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Compras
                        .Where(c => c.Cliente.Id == clienteId)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Compra> FindByVendedorId(UInt32 vendedorId)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Compras
                        .Where(c => c.Vendedor.Id == vendedorId)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Compra> FindByData(DateTime data)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Compras
                        .Where(c => c.Inicio.Date == data.Date)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Novo método: conta clientes distintos que fizeram compras na data informada
        public static int CountClientesPorData(DateTime data)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    var start = data.Date;
                    var end = start.AddDays(1);

                    return dbContext.Compras
                        .Where(c => c.Inicio >= start && c.Inicio < end && c.Cliente != null)
                        .Select(c => c.Cliente.Id)
                        .Distinct()
                        .Count();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Compra> FindByEstado(Estado estado)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Compras
                        .Where(c => c.Estado == estado)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Compra> FindAll()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Compras.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Compra compra)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    dbContext.Compras.Remove(compra);
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
