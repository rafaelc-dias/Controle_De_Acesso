﻿using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IEntradaFuncionarioServico
    {
        Task<int> Cadastrar(EntradaFuncionarioDTO movimento);
        Task AlterarStatus(Guid movimentoId, EStatusMovimento status);
        Task<List<EntradaFuncionario>> Listar();
        Task Excluir(Guid EntradaFuncionarioId);
        Task<EntradaFuncionario> Pesquisar(Guid EntradaFuncionarioId);
    }
}