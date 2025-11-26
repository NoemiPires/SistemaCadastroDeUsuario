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
                        .Where(c => c.VendedorId.Id == vendedorId)
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

        // Soma todas as comissoes de um vendedorId em uma data específica
        public static Decimal SumComissoesByVendedorIdAndDate(UInt32 vendedorId, DateTime data)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    var start = data.Date;
                    var end = start.AddDays(1);
                    return dbContext.Compras
                        .Where(c => c.VendedorId.Id == vendedorId && c.Inicio >= start && c.Inicio < end)
                        .Sum(c => c.Comissao);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Total de vendas em um periodo
        public static Decimal SumVendasByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    var start = startDate.Date;
                    var end = endDate.Date.AddDays(1);
                    return dbContext.Compras
                        .Where(c => c.Inicio >= start && c.Inicio < end)
                        .Sum(c => c.Total);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Datas de vendas de cada vendedorid
        public static List<DateTime> FindDatasByVendedorId(UInt32 vendedorId)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Compras
                        .Where(c => c.VendedorId.Id == vendedorId)
                        .Select(c => c.Inicio.Date)
                        .Distinct()
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
