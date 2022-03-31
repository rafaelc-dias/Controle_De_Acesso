using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IObservacaoRepositorio
    {
        Task<Observacao> Cadastrar(Observacao Observacao);
        Task<Observacao> Atualizar(Observacao Observacao);
        Task<List<Observacao>> Listar();
        Task<Observacao> Excluir(Guid observacaoID);
        Task<Observacao> Pesquisar(Guid observacaoID);
        Task<List<Observacao>> ListarObservacoesMovimento(Guid movimentoId);
    }
}
