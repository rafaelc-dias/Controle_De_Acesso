using ControleAcesso.Class;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.DTO
{
    public class ObservacaoMovimentoPesagemDTO
    {
        public Guid MovimentoId { get; set; }
        public string Obs { get; set; }

        public Observacao ConverteObservacao()
        {
            Observacao observacao = new();

            observacao.AdicionaObservacaoMovimentoPesagem(Obs, MovimentoId);

            return observacao;
        }
    }


}
