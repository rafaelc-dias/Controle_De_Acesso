using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IObservacaoSerivco
    {
        Task Cadastrar(Observacao Observacao);
        Task Atualizar(Observacao Observacao);
        Task<List<Observacao>> Listar();
        Task Excluir(Guid observacaoID);
        Task<Observacao> Pesquisar(Guid observacaoID);
    }
}
