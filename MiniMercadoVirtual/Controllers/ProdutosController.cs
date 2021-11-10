using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniMercadoVirtual.Services;
using MiniMercadoVirtual.Models;

namespace MiniMercadoVirtual.Controllers
{
    public class ProdutosController : Controller
    {
        /*private readonly ProdutosService _produtosService;
        public ProdutosController (ProdutosService produtosService)
        {
            _produtosService = produtosService;
        }
        public IActionResult Index()
        {
            return View(_produtosService.BuscarTodos());
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        public IActionResult Alterar(int id)
        {
            return View(_produtosService.BuscarPorId(id));
        }
        public IActionResult Excluir(int id)
        {
            return View(_produtosService.BuscarPorId(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CriarProduto(Produto produto)
        {
            produto.DtInclusao = DateTime.Now;
            _produtosService.Cadastrar(produto);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarProduto(Produto produto)
        {
            produto.DtAlteracao = DateTime.Now;
            _produtosService.EditarProduto(produto);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletar(Produto produto)
        {
            _produtosService.ExcluirProduto(produto);
            return RedirectToAction(nameof(Index));
        }*/
    }
}