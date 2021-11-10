using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Infra.Models;
using MiniMercadoVirtual.Infra.Repository;


namespace MiniMercadoVirtual.Services.Implementation
{
    public class ClientesService : IClientesService
    {
        private readonly IClientesRepository _iclientesRepository;
        public ClientesService(IClientesRepository clientesRepository)
        {
            _iclientesRepository = clientesRepository;
        }
        public List<Cliente> BuscarTodos()
        {
            return _iclientesRepository.BuscarTodos();
        }
    }
}
