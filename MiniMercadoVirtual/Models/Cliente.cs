using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MiniMercadoVirtual.Models.Enums;

namespace MiniMercadoVirtual.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo nome é um campo obrigatório.")]
        public string Nome { get; set; }
        [Display(Name ="E-mail")]
        [Required(ErrorMessage = "Campo e-mail é um campo obrigatório.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo senha é um campo obrigatório.")]
        public string Senha { get; set; }
        public List<Endereco> Endereco { get; set; }
        [Display(Name ="Data de Cadastro")]
        public DateTime DtInclusao { get; set; }
        [Display(Name = "Data de Atualização")]
        public DateTime DtAlteracao { get; set; }
        public  StatusCliente Status { get; set; }
    }
}
