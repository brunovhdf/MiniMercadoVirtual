using MiniMercadoVirtual.Domain;
using Microsoft.EntityFrameworkCore;

namespace MiniMercadoVirtual.Infra.Repository.Data
{
    public class MiniMercadoVirtualContext : DbContext
    {
        public MiniMercadoVirtualContext(DbContextOptions<MiniMercadoVirtualContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ProdutoPedido> ProdutoPedido { get; set; }
    }
}
