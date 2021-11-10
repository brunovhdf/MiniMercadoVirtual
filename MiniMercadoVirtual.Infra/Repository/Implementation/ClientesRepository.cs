using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Infra.Repository.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MiniMercadoVirtual.Infra.Models;

namespace MiniMercadoVirtual.Infra.Repository.Implementation
{
    public class ClientesRepository : IClientesRepository
    {
        private readonly MiniMercadoVirtualContext _context;
        public ClientesRepository(MiniMercadoVirtualContext context)
        {
            _context = context;
        }
        public List<Cliente> BuscarTodos()
        {
            return _context.Cliente.ToList();
        }
    }
}
