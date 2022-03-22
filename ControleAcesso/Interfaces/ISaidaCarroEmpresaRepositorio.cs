using ControleAcesso.Class;

namespace ControleAcesso.Domain.Interfaces
{
    public interface ISaidaCarroEmpresaRepositorio
    {
        Task AlterarStatusFechado(Guid movimentoId);
        Task InserirEntrada(Guid movimentoId, int kmEntrada, int nivelCombustivelEntrada, string horaEntrada);
        Task<int> Cadastrar(SaidaCarroEmpresa movimento);
        Task Excluir(Guid movimentoId);
        Task<List<SaidaCarroEmpresa>> Listar();
        Task<SaidaCarroEmpresa> Pesquisar(Guid MovimentoId);
    }
}
