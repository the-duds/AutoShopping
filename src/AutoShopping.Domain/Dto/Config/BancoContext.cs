using AutoShopping.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoShopping.Domain.Dto.Config
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options)
          : base(options)
        { }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
