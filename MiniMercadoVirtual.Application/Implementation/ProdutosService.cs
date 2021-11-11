using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Domain;
using MiniMercadoVirtual.Infra.Repository;


namespace MiniMercadoVirtual.Services.Implementation
{
    public class ProdutosService : IProdutosService
    {
        private readonly IProdutosRepository _iprodutosRepository;
        public ProdutosService(IProdutosRepository produtosRepository)
        {
            _iprodutosRepository = produtosRepository;
        }
        public List<Produto> BuscarTodos()
        {
            return _iprodutosRepository.BuscarTodos();
        }
        public Produto BuscarPorId(int id)
        {
            return _iprodutosRepository.BuscarPorId(id);
        }
        public void Cadastrar(Produto produto)
        {
            produto.DtInclusao = DateTime.Now;
            _iprodutosRepository.Cadastrar(produto);
        }
        public void Editar(Produto produto)
        {
            produto.DtAlteracao = DateTime.Now;
            _iprodutosRepository.Editar(produto);
        }
        public void Excluir(Produto produto)
        {
            _iprodutosRepository.Excluir(produto);
        }
    }
}
