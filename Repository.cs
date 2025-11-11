using System;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SistemaCadastroDeUsuario
{
    internal class Repository : DbContext
    {
        private static readonly String _databaseConnection =
            @"server=127.0.0.1;port=3307;uid=root;pwd=;database=Proj1";

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Credencial> Credenciais {  get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public Repository()
        {
            if (Database.EnsureCreated())
            {
                Credencial c2 = new Credencial();
                c2.Senha = "123";
                c2.Gerente = true;
                c2.Nome = "UserPadrao";

                Usuario u2 = new Usuario();
                u2.Nome = "Usuario Padrão";
                u2.Telefone = "349991067708";
                u2.Email = "user@naoseioque";

                u2.Credencial = c2;

                UsuarioRepository.SaveOrUpdate(u2);
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_databaseConnection);
        }
    }
}
