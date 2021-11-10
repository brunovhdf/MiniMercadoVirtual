using System;
using System.Collections.Generic;
using System.Text;
using MiniMercadoVirtual.Domain;
using MiniMercadoVirtual.Infra.Repository;


namespace MiniMercadoVirtual.Services.Implementation
{
    public class EnderecosService : IEnderecosService
    {
        private readonly IEnderecosRepository _ienderecosRepository;
        public EnderecosService(IEnderecosRepository enderecosRepository)
        {
            _ienderecosRepository = enderecosRepository;
        }
        public List<Endereco> BuscarPorCliente(int Id)
        {
            return _ienderecosRepository.BuscarPorCliente(Id);
        }
        public Endereco BuscarPorId(int Id)
        {
            return _ienderecosRepository.BuscarPorId(Id);
        }
        public void Criar(Endereco endereco)
        {
            _ienderecosRepository.Criar(endereco);
        }
        public void Atualizar(Endereco endereco)
        {
            _ienderecosRepository.Atualizar(endereco);
        }
        public void Excluir(Endereco endereco)
        {
            _ienderecosRepository.Excluir(endereco);
        }
    }
}
