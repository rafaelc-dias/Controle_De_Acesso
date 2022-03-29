using ControleAcesso.Class;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.DTO
{
    public class ObservacaosaidaCarroEmpresaDTO
    {
        public Guid MovimentoId { get; set; }
        public string Obs { get; set; }

        public Observacao ConverteObservacao()
        {
            Observacao observacao = new();

            observacao.AdicionaObservacaoSaidaCarroEmpresa(Obs, MovimentoId);

            return observacao;
        }
    }


}
