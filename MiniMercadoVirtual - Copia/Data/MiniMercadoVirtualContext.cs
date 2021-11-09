using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniMercadoVirtual.Models;

namespace MiniMercadoVirtual.Data
{
    public class MiniMercadoVirtualContext : DbContext
    {
        public MiniMercadoVirtualContext (DbContextOptions<MiniMercadoVirtualContext> options) : base(options)
        {
        }
        public DbSet<MiniMercadoVirtual.Models.Cliente> Cliente { get; set; }
    }
}
