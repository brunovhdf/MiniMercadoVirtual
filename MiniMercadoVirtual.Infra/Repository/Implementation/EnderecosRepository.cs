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
        public Endereco BuscarPorId(int Id)
        {
            return _context.Endereco.Where(x => x.Id == Id).FirstOrDefault();
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
