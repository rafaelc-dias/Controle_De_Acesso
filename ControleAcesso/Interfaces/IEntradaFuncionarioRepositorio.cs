﻿using ControleAcesso.Class;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IEntradaFuncionarioRepositorio
    {
        Task<int> Cadastrar(EntradaFuncionario movimento);
        Task AlterarStatus(Guid movimentoId, EStatusMovimento status);
        Task<List<EntradaFuncionario>> Listar();
        Task Excluir(Guid EntradaFuncionarioId);
        Task<EntradaFuncionario> Pesquisar(Guid EntradaFuncionarioId);
    }
}
