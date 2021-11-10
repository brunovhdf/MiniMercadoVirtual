using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Infra.Models;

namespace MiniMercadoVirtual.Infra.Repository
{
    public interface IClientesRepository
    {
        List<Cliente> BuscarTodos();
    }
}
