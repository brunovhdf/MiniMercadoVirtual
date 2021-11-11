using MiniMercadoVirtual.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMercadoVirtual.Services
{
    public interface IPedidosService
    {
        List<Cliente> BuscarTodos();
        Pedido BuscarPorId(int id);
    }
}
