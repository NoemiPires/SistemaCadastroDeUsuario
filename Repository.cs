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

        // Verificar se Credencial deverar ser registrado
        public DbSet<Credencial> Credenciais {  get; set; }

       public Repository() => this.Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_databaseConnection);
        }
    }
}
