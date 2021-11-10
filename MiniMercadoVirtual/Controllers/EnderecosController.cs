using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniMercadoVirtual.Services;
using MiniMercadoVirtual.Models;
using MiniMercadoVirtual.Models.ViewModels;


namespace MiniMercadoVirtual.Controllers
{ 
    public class EnderecosController : Controller
    {
        private readonly IClientesService _iclientesService;
        private readonly IEnderecosService _ienderecosService;
        public EnderecosController(IClientesService iclientesService, IEnderecosService enderecosService)
        {
            _iclientesService = iclientesService;
            _ienderecosService = enderecosService;
        }
        public IActionResult Index()
        {
            var ClienteDomain = _iclientesService.BuscarTodos();
            List<Cliente> Clientes = new List<Cliente>();
            if (ClienteDomain != null)
            {
                foreach (var item in ClienteDomain)
                {
                    Cliente cliente = new Cliente
                    {
                        Nome = item.Nome
                    };
                    if (item.Endereco != null)
                    {
                        List<Endereco> enderecos = new List<Endereco>();
                        foreach (var end in item.Endereco)
                        {
                            Endereco endereco = new Endereco
                            {
                                Id = end.Id,
                                Cep = end.Cep,
                                Logradouro = end.Logradouro,
                                Numero = end.Numero,
                                Bairro = end.Bairro,
                                Cidade = end.Cidade,
                                Uf = end.Uf,
                                Complemento = end.Complemento
                            };
                            enderecos.Add(endereco);
                        }
                        cliente.Endereco = enderecos;
                    }
                    Clientes.Add(cliente);
                }
            }
            return View(Clientes);
        }

        //GET Endereco/Cadastrar
        public IActionResult Cadastrar()
        {
            var clientesDomain = _iclientesService.BuscarTodos();
            List<Cliente> clientes = new List<Cliente>();
            foreach (var item in clientesDomain)
            {
                Cliente cliente = new Cliente
                {
                    Id = item.Id,
                    Nome = item.Nome
                };
                clientes.Add(cliente);
            }
            var ViewModel = new EnderecoFormViewModel { Clientes = clientes };
            return View(ViewModel);
        }

        //POST: Endereco/Cadastrar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Endereco endereco)
        {
            Domain.Endereco enderecoDomain = new Domain.Endereco
            {
                Cep = endereco.Cep,
                Logradouro = endereco.Logradouro,
                Numero = endereco.Numero,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                Uf = endereco.Uf,
                Complemento = endereco.Complemento,
                ClienteId = endereco.ClienteId
            };
            _ienderecosService.Criar(enderecoDomain);
            return RedirectToAction(nameof(Index));
        }
        //GET Endereco/Alterar
        public IActionResult Alterar(int id)
        {
            var enderecoDomain = _ienderecosService.BuscarPorId(id);
            if (enderecoDomain == null)
            {
                return NotFound();
            }
            Endereco endereco = new Endereco
            { 
                Id = enderecoDomain.Id,
                Cep = enderecoDomain.Cep,
                Logradouro = enderecoDomain.Logradouro,
                Numero = enderecoDomain.Numero,
                Bairro = enderecoDomain.Bairro,
                Cidade = enderecoDomain.Cidade,
                Uf = enderecoDomain.Uf,
                Complemento = enderecoDomain.Complemento,
                ClienteId = enderecoDomain.ClienteId
            };

            var clientesDomain = _iclientesService.BuscarTodos();
            List<Cliente> clientes = new List<Cliente>();
            foreach(var item in clientesDomain)
            {
                Cliente cliente = new Cliente
                {
                    Id = item.Id,
                    Nome = item.Nome
                };
                clientes.Add(cliente);
            }
            var ViewModel = new EnderecoFormViewModel { Endereco = endereco,Clientes =  clientes };
            return View(ViewModel);
        }

        //POST: Endereco/Alterar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Atualizar(Endereco endereco)
        {
            Domain.Endereco enderecoDomain = new Domain.Endereco
            {
                Id = endereco.Id,
                Cep = endereco.Cep,
                Logradouro = endereco.Logradouro,
                Numero = endereco.Numero,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                Uf = endereco.Uf,
                Complemento = endereco.Complemento,
                ClienteId = endereco.ClienteId
            };
            _ienderecosService.Atualizar(enderecoDomain);
            return RedirectToAction(nameof(Index));
        }
        
        //GET: Endereco/Excluir
        public IActionResult Excluir(int id)
        {
            var enderecoDomain = _ienderecosService.BuscarPorId(id);
            Endereco endereco = new Endereco
            {
                Id = enderecoDomain.Id,
                Cep = enderecoDomain.Cep,
                Logradouro = enderecoDomain.Logradouro,
                Numero = enderecoDomain.Numero,
                Bairro = enderecoDomain.Bairro,
                Cidade = enderecoDomain.Cidade,
                Uf = enderecoDomain.Uf,
                Complemento = enderecoDomain.Complemento,
                ClienteId = enderecoDomain.ClienteId
            };
            return View(endereco);
        }
        //POST: Endereco/Excluir
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmarExclusao(Endereco endereco)
        {
            Domain.Endereco enderecoDomain = new Domain.Endereco
            {
                Id = endereco.Id,
                Cep = endereco.Cep,
                Logradouro = endereco.Logradouro,
                Numero = endereco.Numero,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                Uf = endereco.Uf,
                Complemento = endereco.Complemento,
                ClienteId = endereco.ClienteId
            };
            _ienderecosService.Excluir(enderecoDomain);
            return RedirectToAction(nameof(Index));
        }
    }
}
