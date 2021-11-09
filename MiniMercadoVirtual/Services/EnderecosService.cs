using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniMercadoVirtual.Data;
using MiniMercadoVirtual.Models;
using MiniMercadoVirtual.Models.ViewModels;

namespace MiniMercadoVirtual.Services
{
    public class EnderecosService
    {
        private readonly MiniMercadoVirtualContext _context;
        public EnderecosService(MiniMercadoVirtualContext context)
        {
            _context = context;
        }
        public Endereco BuscarPorId(int id)
        {
            return _context.Endereco.FirstOrDefault(Obj => Obj.Id == id);
        }
        public List<Endereco> BuscarPorCliente(int id)
        {
            return _context.Endereco.Where(x => x.ClienteId == id).ToList();
        }
        public void Criar(Endereco endereco)
        {
            _context.Add(endereco);
            _context.SaveChanges();
        }
        public void Atualizar(Endereco endereco)
        {
            _context.Update(endereco);
            _context.SaveChanges();
        }
        public void Excluir(Endereco endereco)
        {
            _context.Remove(endereco);
            _context.SaveChanges();
        }
    }
}
