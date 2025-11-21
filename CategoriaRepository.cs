using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class CategoriaRepository
    {
        public static void SaveOrUpdate(Categoria categoria)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    if (categoria.Id == 0)
                    {
                        dbContext.Categorias.Add(categoria);
                    }
                    else
                    {
                        dbContext.Entry(categoria).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Categoria? FindByNome(String nome)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Categorias.Find(nome);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static Categoria? FindById(UInt32 id)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Categorias.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



        public static List<Categoria> FindAll()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Categorias.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Categoria categoria)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    dbContext.Categorias.Remove(categoria);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal static List<Categoria> FindByNome()
        {
            throw new NotImplementedException();
        }
    }

}
