using System;
using System.Collections.Generic;
using MiniMercadoVirtual.Domain.Enums;

namespace MiniMercadoVirtual.Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Endereco Endereco { get; set; }
        public List<ProdutoPedido> ProdutoPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusPedido Status { get; set; }
    }
}
