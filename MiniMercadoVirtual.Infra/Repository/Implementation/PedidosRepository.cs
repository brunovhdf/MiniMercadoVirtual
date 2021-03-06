using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Infra.Repository.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MiniMercadoVirtual.Domain;

namespace MiniMercadoVirtual.Infra.Repository.Implementation
{
    public class PedidosRepository : IPedidosRepository
    {
        private readonly MiniMercadoVirtualContext _context;
        public PedidosRepository(MiniMercadoVirtualContext context)
        {
            _context = context;
        }
        public List<Cliente> BuscarTodos()
        {
            List<Cliente> clientes = _context.Cliente.Include(cliente => cliente.Pedidos).Where(pedidos => pedidos.Pedidos.Count > 0).ThenInclude(pedidos => pedidos.ProdutoPedido).Include(x => x.Endereco).ToList();
            foreach (var cli in clientes)
            {
                foreach(var ped in cli.Pedidos)
                {
                    ped.ProdutoPedido = _context.ProdutoPedido.Where(x => x.PedidoId == ped.Id).ToList();
                }
            }
            return clientes;
        }
        public Pedido BuscarPorId(int id)
        {
            return _context.Pedido.Where(x => x.Id == id).FirstOrDefault();
        }
/*        
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
*/
    }
}
