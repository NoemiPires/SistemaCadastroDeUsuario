using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaCadastroDeUsuario
{
    public class UsuarioRepository
    {
        public static void SaveOrUpdate(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    if (usuario.Id == 0)
                    {
                        dbContext.Usuarios.Add(usuario);
                    }
                    else
                    {
                        dbContext.Entry(usuario).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuario? FindById(UInt64 id) 
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Usuarios.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Usuario> FindAll()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Usuarios.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Usuario> FindAllWithCredencial()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Usuarios.Include("Credencial").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

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
            } catch (Exception)
            {
                throw;
            }
        }
        

    }
}
