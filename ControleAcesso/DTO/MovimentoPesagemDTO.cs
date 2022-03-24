using ControleAcesso.Class;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.DTO
{
    public class MovimentoPesagemDTO
    {
        public DateTime Data { get;  set; }        
        public double PesoChegada { get; private set; }
        public double PesoSaida { get; private set; }
        public double TotalPesoNotaFiscal { get; private set; }
        public Guid VeiculoId { get; set; }
        public Guid PessoaId { get; set; }

    }
}
