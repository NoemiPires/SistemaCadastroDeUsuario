using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaCadastroDeUsuario
{
    internal class CredencialRepository
    {
        public static void SaveOrUpdate(Credencial credencial)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    if (credencial.Id == 0)
                    {
                        dbContext.Credenciais.Add(credencial);
                    }
                    else
                    {
                        dbContext.Entry(credencial).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Credencial? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Credenciais.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Credencial> FindAll()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Credenciais.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Credencial credencial)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    dbContext.Credenciais.Attach(credencial);
                    dbContext.Credenciais.Remove(credencial);

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
