using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniMercadoVirtual.Models;

namespace MiniMercadoVirtual.Models.ViewModels
{
    public class EnderecoFormViewModel
    {
        public Endereco Endereco { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
