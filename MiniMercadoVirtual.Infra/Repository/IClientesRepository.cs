using MiniMercadoVirtual.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMercadoVirtual.Infra.Repository
{
    public interface IClientesRepository
    {
        List<Cliente> BuscarTodos();
    }
}
