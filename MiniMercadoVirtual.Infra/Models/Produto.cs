using System;
using MiniMercadoVirtual.Infra.Models.Enums;

namespace MiniMercadoVirtual.Infra.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public StatusProduto Status { get; set; }
    }
}
