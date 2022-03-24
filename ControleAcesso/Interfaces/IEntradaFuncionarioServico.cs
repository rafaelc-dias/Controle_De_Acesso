using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IEntradaFuncionarioServico
    {
        Task<int> Cadastrar(EntradaFuncionarioDTO movimentoDTO);
        Task AlterarStatusFechado(Guid movimentoId);
        Task AdicionaDataSaida(Guid movimentoId);
        Task<List<EntradaFuncionario>> Listar();
        Task Excluir(Guid EntradaFuncionarioId);
        Task<EntradaFuncionario> Pesquisar(Guid EntradaFuncionarioId);
    }
}
