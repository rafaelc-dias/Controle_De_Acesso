using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IObservacaoSerivco
    {
        Task<bool> Cadastrar(ObservacaoMovimentoPesagemDTO observacaoDTO);
        Task<List<Observacao>> Listar();
        Task<List<Observacao>> ListarObservacoesMovimento(Guid movimentoID);
        Task<Observacao> Pesquisar(Guid observacaoID);
    }
}
