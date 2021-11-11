using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniMercadoVirtual.Models
{
    public class ProdutoPedido
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public int PedidoId { get; set; }
    }
}
