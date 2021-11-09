using MiniMercadoVirtual.Domain;
using MiniMercadoVirtual.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMercadoVirtual.Services.Implementation
{
    public class ClientesService : IClientesService
    {
        private readonly IClientesRepository _clientesRepository;
        public ClientesService(IClientesRepository clientesRepository)
        {
            _clientesRepository = clientesRepository;
        }
        public List<Cliente> BuscarTodos()
        {
            return _clientesRepository.BuscarTodos();
        }
    }
}
