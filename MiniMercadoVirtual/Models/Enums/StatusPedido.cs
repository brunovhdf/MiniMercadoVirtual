using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniMercadoVirtual.Models.Enums
{
    public enum StatusPedido : int
    {
        Liberado = 1,
        Bloqueado = 2,
        Separacao = 3,
        Entregue = 4
    }
}
