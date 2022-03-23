using ControleAcesso.Class;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IMovimentoPesagemRepositorio
    {
        Task AlterarStatusFechado(Guid movimentoId);
        //Task InserirEntrada(Guid movimentoId, int kmEntrada, int nivelCombustivelEntrada, string horaEntrada);
        Task<int> Cadastrar(MovimentoPesagem movimento);
        Task Excluir(Guid movimentoId);
        Task<List<MovimentoPesagem>> Listar();
        Task<MovimentoPesagem> Pesquisar(Guid MovimentoId);
    }
}
