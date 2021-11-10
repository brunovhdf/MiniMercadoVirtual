using MiniMercadoVirtual.Infra.Models;
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
    }
}
