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
        /*private readonly EnderecosService _enderecosService;
        private readonly ClientesServices _clientesSevice;

        public EnderecosController(EnderecosService enderecosService,ClientesServices clientesService)
        {
            _enderecosService = enderecosService;
            _clientesSevice = clientesService;
        }
        public IActionResult Index()
        {
            return View(_clientesSevice.BuscarTodos());
        }
        //GET Endereco/Cadastrar
        public IActionResult Cadastrar()
        {
            var ViewModel = new EnderecoFormViewModel{Clientes = _clientesSevice.BuscarTodos()};
            return View(ViewModel);
        }
        //POST: Endereco/Cadastrar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Endereco endereco)
        {
            _enderecosService.Criar(endereco);
            return RedirectToAction(nameof(Index));
        }
        //GET Endereco/Alterar
        public IActionResult Alterar(int id)
        {
            var endereco = _enderecosService.BuscarPorId(id);
            if (endereco == null)
            {
                return NotFound();
            }
            var clientes = _clientesSevice.BuscarTodos();
            var ViewModel = new EnderecoFormViewModel { Endereco = endereco,Clientes =  clientes };
            return View(ViewModel);
        }
        //POST: Endereco/Alterar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Atualizar(Endereco endereco)
        {
            _enderecosService.Atualizar(endereco);
            return RedirectToAction(nameof(Index));
        }
        //GET: Endereco/Excluir
        public IActionResult Excluir(int id)
        {
            
            return View(_enderecosService.BuscarPorId(id));
        }
        //POST: Endereco/Excluir
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmarExclusao(Endereco endereco)
        {
            _enderecosService.Excluir(endereco);
            return RedirectToAction(nameof(Index));
        }*/
    }
}
