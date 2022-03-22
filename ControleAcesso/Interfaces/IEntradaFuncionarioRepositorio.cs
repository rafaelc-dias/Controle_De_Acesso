using ControleAcesso.Class;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IEntradaFuncionarioRepositorio
    {
        Task<int> Cadastrar(EntradaFuncionario movimento);
        Task AlterarStatusFechado(Guid movimentoId);
        Task AdicionaDataSaida(Guid movimentoId);
        Task<List<EntradaFuncionario>> Listar();
        Task Excluir(Guid EntradaFuncionarioId);
        Task<EntradaFuncionario> Pesquisar(Guid EntradaFuncionarioId);
    }
}
