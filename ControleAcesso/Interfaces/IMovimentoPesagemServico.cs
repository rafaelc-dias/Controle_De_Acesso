using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IMovimentoPesagemServico
    {
        Task AlterarStatusFechado(Guid movimentoId);
        //Task InserirEntrada(Guid movimentoId, int kmEntrada, int nivelCombustivelEntrada, string horaEntrada);
        Task<int> Cadastrar(MovimentoPesagemDTO movimentoDTO);        
        Task Excluir(Guid movimentoId);
        Task<List<MovimentoPesagem>> Listar();
        Task<MovimentoPesagem> Pesquisar(Guid MovimentoId);
        Task DefinirPesoSaida(MovimentoPesagemPesoSaidaDTO movimentoPesagemPesoSaidaDTO);
        Task DefinirStatusPesagem(Guid movimentoId);
    }
}
