using MiniMercadoVirtual.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMercadoVirtual.Services
{
    public interface IEnderecosService
    {
        List<Endereco> BuscarPorCliente(int id);
    }
}
