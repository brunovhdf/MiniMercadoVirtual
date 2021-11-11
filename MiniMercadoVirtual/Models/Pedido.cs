using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniMercadoVirtual.Models.Enums;

namespace MiniMercadoVirtual.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int EnderecoId { get; set; }
        public List<ProdutoPedido> ProdutoPedido { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusPedido Status { get; set; }
    }
}
