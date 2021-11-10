using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Infra.Repository.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MiniMercadoVirtual.Domain;

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
            return _context.Cliente.Include(x => x.Endereco).ToList();
        }
        public Cliente BuscarPorId(int id)
        {
            return _context.Cliente.Where(x => x.Id == id).FirstOrDefault();
        }
        public void Cadastrar(Cliente cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
        }
        public void Alterar(Cliente cliente)
        {
            _context.Update(cliente);
            _context.SaveChanges();
        }
        public void Remover(Cliente cliente)
        {
            _context.Remove(cliente);
            _context.SaveChanges();
        }
    }
}
