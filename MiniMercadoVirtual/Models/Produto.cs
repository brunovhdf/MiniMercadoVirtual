using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MiniMercadoVirtual.Models.Enums;

namespace MiniMercadoVirtual.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome do produto é um campo obrigatório.")]
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Preço do produto é um campo obrigatório.")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Preco { get; set; }
        [Display(Name = "Data Inclusão")]
        public DateTime DtInclusao { get; set; }
        [Display(Name = "Data Alteração")]
        public DateTime DtAlteracao { get; set; }
        public StatusProduto Status { get; set; }
    }
}
