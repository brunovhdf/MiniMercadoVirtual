using MiniMercadoVirtual.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMercadoVirtual.Services
{
    public interface IEnderecosService
    {
        List<Endereco> BuscarPorCliente(int id);
        Endereco BuscarPorId(int Id);
        void Criar(Endereco endereco);
        void Atualizar(Endereco endereco);
        void Excluir(Endereco endereco);
    }
}
