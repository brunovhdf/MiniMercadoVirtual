using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Domain;
using MiniMercadoVirtual.Infra.Repository;


namespace MiniMercadoVirtual.Services.Implementation
{
    public class PedidosService : IPedidosService
    {
        private readonly IPedidosRepository _ipedidosRepository;
        public PedidosService(IPedidosRepository pedidosRepository)
        {
            _ipedidosRepository = pedidosRepository;
        }
        public List<Cliente> BuscarTodos()
        {
            return _ipedidosRepository.BuscarTodos();
        }
        public Pedido BuscarPorId(int id)
        {
            return _ipedidosRepository.BuscarPorId(id);
        }
    }
}
