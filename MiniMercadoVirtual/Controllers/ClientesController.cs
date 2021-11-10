using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiniMercadoVirtual.Services;
using MiniMercadoVirtual.Models;
using MiniMercadoVirtual.Models.ViewModels;

namespace MiniMercadoVirtual.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClientesService _iclientesService;
        private readonly IEnderecosService _ienderecosService;
        public ClientesController(IClientesService iclientesService, IEnderecosService enderecosService)
        {
            _iclientesService = iclientesService;
            _ienderecosService = enderecosService;
        }

        // GET: Clientes
        public IActionResult Index()
        {
            var ClientesDomain = _iclientesService.BuscarTodos();
            List<Cliente> Clientes = new List<Cliente>();
            foreach (var item in ClientesDomain)
            {
                Cliente Cliente = new Cliente
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Email = item.Email,
                    Senha = item.Senha,
                    Status = (Models.Enums.StatusCliente)item.Status
                };
                Clientes.Add(Cliente);
            }
            return View(Clientes);
        }

        // GET: Clientes/Details
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ClienteDomain = _iclientesService.BuscarPorId(id.Value);
            Cliente Cliente = new Cliente();
            if (ClienteDomain == null)
            {
                return NotFound();
            }
            else
            {
                Cliente.Id = ClienteDomain.Id;
                Cliente.Nome = ClienteDomain.Nome;
                Cliente.Email = ClienteDomain.Email;
                Cliente.Senha = ClienteDomain.Senha;
                Cliente.DtInclusao = ClienteDomain.DtInclusao;
                Cliente.DtAlteracao = ClienteDomain.DtAlteracao;
                Cliente.Status = (Models.Enums.StatusCliente)ClienteDomain.Status;
            }
            var EnderecosDomain = _ienderecosService.BuscarPorCliente(Cliente.Id);
            List<Endereco> enderecos = new List<Endereco>();
            if (EnderecosDomain != null)
            {
                foreach (var item in EnderecosDomain)
                {
                    Endereco endereco = new Endereco
                    {
                        Id = item.Id,
                        Cep = item.Cep,
                        Logradouro = item.Logradouro,
                        Numero = item.Numero,
                        Bairro = item.Bairro,
                        Cidade = item.Cidade,
                        Uf = item.Uf,
                        Complemento = item.Complemento,
                        ClienteId = item.ClienteId
                    };
                    enderecos.Add(endereco);
                }
            }
            Cliente.Endereco = enderecos;
            return View(Cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cliente Cliente)
        {
            if (ModelState.IsValid)
            {
                Domain.Cliente ClienteDomain = new Domain.Cliente
                {
                    Nome = Cliente.Nome,
                    Email = Cliente.Email,
                    Senha = Cliente.Senha,
                    Status = (Domain.Enums.StatusCliente)Cliente.Status
                };
                _iclientesService.Cadastrar(ClienteDomain);
                return RedirectToAction(nameof(Index));
            }
            return View(Cliente);
        }

        // GET: Clientes/Edit
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ClienteDomain = _iclientesService.BuscarPorId(id.Value);
            if (ClienteDomain == null)
            {
                return NotFound();
            }
            Cliente Cliente = new Cliente
            {
                Id = ClienteDomain.Id,
                DtInclusao = ClienteDomain.DtInclusao,
                Nome = ClienteDomain.Nome,
                Senha = ClienteDomain.Senha,
                Email = ClienteDomain.Email,
                Status = (Models.Enums.StatusCliente)ClienteDomain.Status
            };
            return View(Cliente);
        }


        // POST: Clientes/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cliente Cliente)
        {
            if (ModelState.IsValid)
            {
                Domain.Cliente ClienteDomain = new Domain.Cliente
                {
                    Id = Cliente.Id,
                    DtInclusao = Cliente.DtInclusao,
                    Nome = Cliente.Nome,
                    Email = Cliente.Email,
                    Senha = Cliente.Senha,
                    Status = (Domain.Enums.StatusCliente)Cliente.Status
                };
                _iclientesService.Alterar(ClienteDomain);
                return RedirectToAction(nameof(Index));
            }
            return View(Cliente);
        }

        // GET: Clientes/Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var clienteDomain = _iclientesService.BuscarPorId(id.Value);
            if (clienteDomain == null)
            {
                return NotFound();
            }
            Cliente cliente = new Cliente
            {
                Id = clienteDomain.Id,
                Nome = clienteDomain.Nome,
                Email = clienteDomain.Email,
                Senha = clienteDomain.Senha,
                DtInclusao = clienteDomain.DtInclusao,
                DtAlteracao = clienteDomain.DtAlteracao,
                Status = (Models.Enums.StatusCliente)clienteDomain.Status
            };
            return View(cliente);
        }

        // POST: Clientes/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var cliente = _iclientesService.BuscarPorId(id);
            if(cliente == null)
            {
                return NotFound();
            }
            _iclientesService.Remover(cliente);
            return RedirectToAction(nameof(Index));
        }
    }
}
