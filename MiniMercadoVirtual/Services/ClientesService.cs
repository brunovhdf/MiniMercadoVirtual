using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniMercadoVirtual.Models;
using MiniMercadoVirtual.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace MiniMercadoVirtual.Services
{
    public class ClientesService
    {
        private readonly MiniMercadoVirtualContext _context;
        public ClientesService(MiniMercadoVirtualContext context)
        {
            _context = context;
        }
        public List<Cliente> BuscarTodos()
        {
            return _context.Cliente.ToList();
        }
        public Cliente BuscarPorId(int id)
        {
            return _context.Cliente.FirstOrDefault(m => m.Id == id);
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
            _context.Cliente.Remove(cliente);
            _context.SaveChanges();
        }
    }
}
