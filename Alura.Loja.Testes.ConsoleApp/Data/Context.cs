﻿using Alura.Loja.Testes.ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Alura.Loja.Testes.ConsoleApp.Data
{
    internal class Context : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PromocaoProduto>().HasKey(pp => new {pp.PromocaoId, pp.ProdutoId});

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=lojadb;Trusted_Connection=true;");
        }
    }
}
