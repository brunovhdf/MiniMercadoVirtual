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
        private readonly IProdutosService _iprodutosService;
        public ProdutosController (IProdutosService iprodutosService)
        {
            _iprodutosService = iprodutosService;
        }
        public IActionResult Index()
        {
            var produtosDomain = _iprodutosService.BuscarTodos();
            List<Produto> produtos = new List<Produto>();
            foreach(var item in produtosDomain)
            {
                var produto = new Produto
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Descricao = item.Descricao,
                    Preco = item.Preco,
                    DtInclusao = item.DtInclusao,
                    DtAlteracao = item.DtAlteracao,
                    Status = (Models.Enums.StatusProduto)item.Status
                };
                produtos.Add(produto);
            }
            return View(produtos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        public IActionResult Alterar(int id)
        {
            Domain.Produto produtoDomain = _iprodutosService.BuscarPorId(id);
            Produto produto = new Produto
            {
                Id = produtoDomain.Id,
                Nome = produtoDomain.Nome,
                Descricao = produtoDomain.Descricao,
                Preco = produtoDomain.Preco,
                DtInclusao = produtoDomain.DtInclusao,
                Status = (Models.Enums.StatusProduto)produtoDomain.Status
            };
            return View(produto);
        }
        public IActionResult Excluir(int id)
        {
            Domain.Produto produtoDomain = _iprodutosService.BuscarPorId(id);
            Produto produto = new Produto
            {
                Id = produtoDomain.Id,
                Nome = produtoDomain.Nome,
                Descricao = produtoDomain.Descricao,
                Preco = produtoDomain.Preco,
                DtInclusao = produtoDomain.DtInclusao,
                DtAlteracao = produtoDomain.DtAlteracao,
                Status = (Models.Enums.StatusProduto)produtoDomain.Status
            };
            return View(produto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CriarProduto(Produto produto)
        {
            Domain.Produto produtoDomain = new Domain.Produto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Preco = produto.Preco,
                Status = (Domain.Enums.StatusProduto)produto.Status
            };
            _iprodutosService.Cadastrar(produtoDomain);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarProduto(Produto produto)
        {
            Domain.Produto produtoDomain = new Domain.Produto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Preco = produto.Preco,
                Status = (Domain.Enums.StatusProduto)produto.Status
            };
            _iprodutosService.Editar(produtoDomain);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletar(Produto produto)
        {
            Domain.Produto produtoDomain = new Domain.Produto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                DtInclusao = produto.DtInclusao,
                DtAlteracao = produto.DtAlteracao,
                Preco = produto.Preco,
                Status = (Domain.Enums.StatusProduto)produto.Status
            };
            _iprodutosService.Excluir(produtoDomain);
            return RedirectToAction(nameof(Index));
        }
    }
}