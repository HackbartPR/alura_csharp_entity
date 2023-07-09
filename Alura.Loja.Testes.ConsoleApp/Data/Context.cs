using Alura.Loja.Testes.ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Alura.Loja.Testes.ConsoleApp.Data
{
    internal class Context : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=lojadb;Trusted_Connection=true;");
        }
    }
}
