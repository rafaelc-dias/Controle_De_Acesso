using ControleAcesso.Class;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IMovimentoPesagemRepositorio
    {
        Task AlterarStatusFechado(Guid movimentoId);
        Task<int> Cadastrar(MovimentoPesagem movimento);
        Task<int> Atualizar(MovimentoPesagem movimento);
        Task Excluir(Guid movimentoId);
        Task<List<MovimentoPesagem>> Listar();
        Task<MovimentoPesagem> Pesquisar(Guid MovimentoId);
        Task DefinirPesoSaida(Guid movimentoId, double pesoSaida);
        Task DefinirStatusPesagem(Guid movimentoId);
    }
}
