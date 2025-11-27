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

        // Encontrar cliente pelo nome
        public static Cliente FindByNome()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Clientes
                        .Where(c => c.Nome == c.Nome)
                        .FirstOrDefault()!;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        // Buscar todos os nomes dos clientes
        public static List<Cliente> FindAllNomes()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Clientes
                        .Select(c => new Cliente { Nome = c.Nome })
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Listar os nomes dos clientes
        public static List<String> FindNomes()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Clientes
                        .Select(c => c.Nome)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Listar Compras pelo id do cliente
        public static List<Compra> FindComprasByClienteId(UInt32 clienteId)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    Cliente? cliente = dbContext.Clientes
                        .Where(c => c.Id == clienteId)
                        .FirstOrDefault();
                    if (cliente != null)
                    {
                        return cliente.Compras;
                    }
                    else
                    {
                        return new List<Compra>();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Buscar id pelo nome
        public static UInt32? FindIdByNome(String nome)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    Cliente? cliente = dbContext.Clientes
                        .Where(c => c.Nome == nome)
                        .FirstOrDefault();
                    if (cliente != null)
                    {
                        return cliente.Id;
                    }
                    else
                    {
                        return null;
                    }
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

        public static Cliente FindByCpf(String cpf)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Clientes
                        .Where(c => c.Cpf == cpf)
                        .FirstOrDefault()!;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Listar todos os clientes que estão com o estado pendente
        //em suas compras
        public static List<Cliente> FindByCompraPendente()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Clientes
                        .Where(c => c.Compras
                            .Any(compra => compra.Estado == Estado.PENDENTE))
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Cliente> FindAll()
        {
            try
            {
                using (Repository dbContext = new())
                {
                    return dbContext.Clientes.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Cliente cliente)
        {
            try
            {
                using (Repository dbContext = new())
                {
                    dbContext.Clientes.Remove(cliente);
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
