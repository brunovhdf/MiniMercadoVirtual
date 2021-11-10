using System;
using System.Collections.Generic;
using MiniMercadoVirtual.Infra.Models.Enums;

namespace MiniMercadoVirtual.Infra.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<Endereco> Endereco { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public  StatusCliente Status { get; set; }
    }
}
