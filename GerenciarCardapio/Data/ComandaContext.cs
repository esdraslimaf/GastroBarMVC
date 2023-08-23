using GerenciarCardapio.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciarCardapio.Data
{
    public class ComandaContext : DbContext
    {
        public ComandaContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ComandaProduto> ProdutosComandas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<Comanda>()
       .Property(c => c.ValorTotal)
       .HasColumnType("decimal(18, 2)");

        modelBuilder.Entity<Produto>()
       .Property(p => p.PrecoUnitario)
       .HasColumnType("decimal(18, 2)");


        }

    }
}
