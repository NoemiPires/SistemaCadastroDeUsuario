using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroDeUsuario
{
    public class ProdutoRepository
    {
        public static void SaveOrUpdate(Produto produto)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    if (produto.Id == 0)
                    {
                        dbContext.Produtos.Add(produto);
                    }
                    else
                    {
                        dbContext.Entry(produto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Produto? FindById(UInt32 id)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Produtos.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Produto> FindAll()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Produtos.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Produto> FindByNome(String nome)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Produtos
                        .Where(produto => produto.Nome.Contains(nome))
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Produto> FindByEstoqueMinimo()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Produtos
                        .Where(produto => produto.Estoque <= produto.EstoqueMinimo)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Produto produto)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    dbContext.Produtos.Remove(produto);
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
