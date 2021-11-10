using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Domain;

namespace MiniMercadoVirtual.Infra.Repository
{
    public interface IEnderecosRepository
    {
        List<Endereco> BuscarPorCliente(int Id);
    }
}
