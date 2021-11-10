using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Domain;
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
        public Cliente BuscarPorId(int id)
        {
            return _iclientesRepository.BuscarPorId(id);
        }
        public void Cadastrar(Cliente cliente)
        {
            cliente.DtInclusao = DateTime.Now;
            _iclientesRepository.Cadastrar(cliente);
        }
        public void Alterar(Cliente cliente)
        {
            cliente.DtAlteracao = DateTime.Now;
            _iclientesRepository.Alterar(cliente);
        }
        public void Remover(Cliente cliente)
        {
            _iclientesRepository.Remover(cliente);
        }
    }
}
