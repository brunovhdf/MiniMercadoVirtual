using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Domain;

namespace MiniMercadoVirtual.Infra.Repository
{
    public interface IClientesRepository
    {
        List<Cliente> BuscarTodos();
        Cliente BuscarPorId(int id);
        void Cadastrar(Cliente cliente);
        void Alterar(Cliente cliente);
        void Remover(Cliente cliente);
    }
}
