using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class PagamentoRepository
    {
        public static void SaveOrUpdate(Pagamento pagamento)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    if (pagamento.Id == 0)
                    {
                        dbContext.Set<Pagamento>().Add(pagamento);
                    }
                    else
                    {
                        dbContext.Entry(pagamento).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public static Pagamento? FindById(UInt32 id)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Set<Pagamento>().Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public static List<Pagamento> FindAll()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Set<Pagamento>().ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Pagamento pagamento)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    dbContext.Set<Pagamento>().Remove(pagamento);
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
