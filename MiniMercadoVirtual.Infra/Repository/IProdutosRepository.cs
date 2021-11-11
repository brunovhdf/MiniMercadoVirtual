using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Domain;

namespace MiniMercadoVirtual.Infra.Repository
{
    public interface IProdutosRepository
    {
        List<Produto> BuscarTodos();
        Produto BuscarPorId(int id);
        void Cadastrar(Produto produto);
        void Editar(Produto produto);
        void Excluir(Produto produto);
    }
}
