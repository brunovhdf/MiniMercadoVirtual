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
        private readonly IClientesService _iClientesService;

        public ClientesController(IClientesService iclientesService)
        {
            _iClientesService = iclientesService;
        }

        // GET: Clientes
        public IActionResult Index()
        {
            var ClientesInfra = _iClientesService.BuscarTodos();
            List<Cliente> Clientes = new List<Cliente>();
            foreach (var item in ClientesInfra)
            {
                Cliente cliente = new Cliente
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Email = item.Email,
                    Senha = item.Senha,
                    Status = (Models.Enums.StatusCliente)item.Status
                };
                Clientes.Add(cliente);
            }
            return View(Clientes);
        }
        /*      // GET: Clientes/Details
                public IActionResult Details(int? id)
                {
                    if (id == null)
                    {
                        return NotFound();
                    }

                    var cliente = _clientesService.BuscarPorId(id.Value);
                    if (cliente == null)
                    {
                        return NotFound();
                    }
                    var enderecos = _enderecoService.BuscarPorCliente(cliente.Id);
                    cliente.Endereco = enderecos;

                    return View(cliente);
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
                public IActionResult Create(Cliente cliente)
                {
                    if (ModelState.IsValid)
                    {
                        cliente.DtInclusao = DateTime.Now;
                        _clientesService.Cadastrar(cliente);
                        return RedirectToAction(nameof(Index));
                    }
                    return View(cliente);
                }

                // GET: Clientes/Edit
                public IActionResult Edit(int? id)
                {
                    if (id == null)
                    {
                        return NotFound();
                    }

                    var cliente = _clientesService.BuscarPorId(id.Value);
                    if (cliente == null)
                    {
                        return NotFound();
                    }
                    return View(cliente);
                }

                // POST: Clientes/Edit
                // To protect from overposting attacks, enable the specific properties you want to bind to.
                // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
                [HttpPost]
                [ValidateAntiForgeryToken]
                public IActionResult Edit(int id, Cliente cliente)
                {
                    if (id != cliente.Id)
                    {
                        return NotFound();
                    }

                    if (ModelState.IsValid)
                    {

                        cliente.DtAlteracao = DateTime.Now;
                        _clientesService.Alterar(cliente);
                        return RedirectToAction(nameof(Index));
                    }
                    return View(cliente);
                }

                // GET: Clientes/Delete
                public IActionResult Delete(int? id)
                {
                    if (id == null)
                    {
                        return NotFound();
                    }
                    var cliente = _clientesService.BuscarPorId(id.Value);
                    if (cliente == null)
                    {
                        return NotFound();
                    }

                    return View(cliente);
                }

                // POST: Clientes/Delete
                [HttpPost, ActionName("Delete")]
                [ValidateAntiForgeryToken]
                public IActionResult DeleteConfirmed(int id)
                {
                    var cliente = _clientesService.BuscarPorId(id);
                    _clientesService.Remover(cliente);
                    return RedirectToAction(nameof(Index));
                }
         */
    }
}
