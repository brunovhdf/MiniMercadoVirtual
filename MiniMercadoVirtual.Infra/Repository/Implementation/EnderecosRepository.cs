using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Infra.Repository.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MiniMercadoVirtual.Domain;

namespace MiniMercadoVirtual.Infra.Repository.Implementation
{
    public class EnderecosRepository : IEnderecosRepository
    {
        private readonly MiniMercadoVirtualContext _context;
        public EnderecosRepository(MiniMercadoVirtualContext context)
        {
            _context = context;
        }
        public List<Endereco> BuscarPorCliente(int Id)
        {
            return _context.Endereco.Where(x => x.ClienteId == Id).ToList();
        }
    }
}
