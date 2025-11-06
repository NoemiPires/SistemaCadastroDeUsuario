using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaCadastroDeUsuario
{
    public class ItemRepository
    {
        public static void SaveOrUpdate(Item item)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (item.Id == 0)
                    {
                        dbContext.Itens.Add(item);
                    }
                    else
                    {
                        dbContext.Entry(item).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Item? FindById(UInt32 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Itens.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Item> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Itens.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public static List<Item> FindAllWithCredencial()
        //{
        //    try
        //    {
        //        using (Repository dbContext = new())
        //        {
        //            return dbContext.Usuarios.Include("Credencial").ToList();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public static void Delete(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    dbContext.Usuarios.Attach(usuario);
                    dbContext.Usuarios.Remove(usuario);

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
