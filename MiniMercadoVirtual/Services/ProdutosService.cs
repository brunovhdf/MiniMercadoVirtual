using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniMercadoVirtual.Data;
using MiniMercadoVirtual.Models;

namespace MiniMercadoVirtual.Services
{
    public class ProdutosService
    {
        private readonly MiniMercadoVirtualContext _context;
        public ProdutosService(MiniMercadoVirtualContext context)
        {
            _context = context;
        }
        public List<Produto> BuscarTodos()
        {
            return _context.Produto.ToList();
        }
        public Produto BuscarPorId(int id)
        {
            return _context.Produto.FirstOrDefault(x => x.Id == id);
        }
        public void Cadastrar(Produto produto)
        {
            _context.Add(produto);
            _context.SaveChanges();
        }
        public void EditarProduto(Produto produto)
        {
            _context.Update(produto);
            _context.SaveChanges();
        }
        public void ExcluirProduto(Produto produto)
        {
            _context.Remove(produto);
            _context.SaveChanges();
        }
    }
}