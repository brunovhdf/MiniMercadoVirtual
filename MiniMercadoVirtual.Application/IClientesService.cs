using MiniMercadoVirtual.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMercadoVirtual.Services
{
    public interface IClientesService
    {
        List<Cliente> BuscarTodos();
        Cliente BuscarPorId(int id);
        void Cadastrar(Cliente cliente);
        void Alterar(Cliente cliente);
        void Remover(Cliente cliente);
    }
}
