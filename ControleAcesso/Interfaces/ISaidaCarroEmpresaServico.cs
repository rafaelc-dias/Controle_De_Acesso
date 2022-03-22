using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;

namespace ControleAcesso.Domain.Interfaces
{
    public interface ISaidaCarroEmpresaServico
    {
        Task AlterarStatusFechado(Guid movimentoId);
        Task InserirEntrada(SaidaCarroEmpresaEntradaDTO movimento);
        Task<int> Cadastrar(SaidaCarroEmpresaSaidaDTO movimento);
        Task Excluir(Guid movimentoId);
        Task<List<SaidaCarroEmpresa>> Listar();
        Task<SaidaCarroEmpresa> Pesquisar(Guid MovimentoId);
    }
}
