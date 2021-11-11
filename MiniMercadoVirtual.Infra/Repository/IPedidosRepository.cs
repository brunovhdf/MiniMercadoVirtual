using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Domain;

namespace MiniMercadoVirtual.Infra.Repository
{
    public interface IPedidosRepository
    {
        List<Cliente> BuscarTodos();
        Pedido BuscarPorId(int id);
        //void Cadastrar(Produto produto);
        //void Editar(Produto produto);
        //void Excluir(Produto produto);
    }
}
