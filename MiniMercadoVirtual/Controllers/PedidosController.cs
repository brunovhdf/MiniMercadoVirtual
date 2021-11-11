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
    public class PedidosController : Controller
    {
        private readonly IPedidosService _ipedidosService;
        public PedidosController(IPedidosService ipedidosService)
        {
            _ipedidosService = ipedidosService;
        }
        public IActionResult Index()
        {
            var clienteDomain = _ipedidosService.BuscarTodos();
            List<Cliente> clientes = new List<Cliente>();
            foreach(var cli in clienteDomain)
            {
                Cliente cliente = new Cliente
                {
                    Nome = cli.Nome
                };
                List<Pedido> pedidos = new List<Pedido>();
                foreach(var ped in cli.Pedidos)
                {
                    Pedido pedido = new Pedido
                    {
                        Id = ped.Id,
                        ClienteId = ped.ClienteId,
                        EnderecoId = ped.EnderecoId,
                        DtInclusao = ped.DtInclusao,
                        DtAlteracao = ped.DtAlteracao,
                        ValorTotal = ped.ValorTotal,
                        Status = (Models.Enums.StatusPedido)ped.Status
                    };
                    List<ProdutoPedido> produtos = new List<ProdutoPedido>();
                    foreach(var prod in ped.ProdutoPedido)
                    {
                        ProdutoPedido produto = new ProdutoPedido
                        {
                            Id = prod.Id,
                            Nome = prod.Nome,
                            Preco = prod.Preco,
                            Quantidade = prod.Quantidade,
                            ValorTotal = prod.ValorTotal
                        };
                        produtos.Add(produto);
                    }
                    pedido.ProdutoPedido = produtos;
                    pedidos.Add(pedido);
                }
                List<Endereco> enderecos = new List<Endereco>();
                foreach(var end in cli.Endereco)
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
                cliente.Pedidos = pedidos;
                clientes.Add(cliente);
            }
            return View(clientes);
        }
    }
}