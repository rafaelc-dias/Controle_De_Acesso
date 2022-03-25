using ControleAcesso.Class;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.DTO
{
    public class MovimentoPesagemDTO
    {
        public ETipoMovimentoPesagem TipoMovimento { get; set; }
        public DateTime Data { get;  set; }        
        public double PesoChegada { get;  set; }
        public double PesoSaida { get;  set; }
        public double TotalPesoNotaFiscal { get;  set; }
        public Guid VeiculoId { get; set; }
        public Guid PessoaId { get; set; }

    }
}
