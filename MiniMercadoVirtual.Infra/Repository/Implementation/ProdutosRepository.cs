using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Infra.Repository.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MiniMercadoVirtual.Domain;

namespace MiniMercadoVirtual.Infra.Repository.Implementation
{
    public class ProdutosRepository : IProdutosRepository
    {
        private readonly MiniMercadoVirtualContext _context;
        public ProdutosRepository(MiniMercadoVirtualContext context)
        {
            _context = context;
        }
        public List<Produto> BuscarTodos()
        {
            return _context.Produto.ToList();
        }
        public Produto BuscarPorId(int id)
        {
            return _context.Produto.Where(x => x.Id == id).FirstOrDefault();
        }
        public void Cadastrar(Produto produto)
        {
            _context.Add(produto);
            _context.SaveChanges();
        }
        public void Editar(Produto produto)
        {
            _context.Update(produto);
            _context.SaveChanges();
        }
        public void Excluir(Produto produto)
        {
            _context.Remove(produto);
            _context.SaveChanges();
        }
    }
}
