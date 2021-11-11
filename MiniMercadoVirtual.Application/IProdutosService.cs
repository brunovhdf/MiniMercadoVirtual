using MiniMercadoVirtual.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMercadoVirtual.Services
{
    public interface IProdutosService
    {
        List<Produto> BuscarTodos();
        Produto BuscarPorId(int id);
        void Cadastrar(Produto produto);
        void Editar(Produto produto);
        void Excluir(Produto produto);
    }
}
