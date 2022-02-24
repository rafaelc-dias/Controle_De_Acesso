using ControleAcesso.Class;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.DTO
{
    public class MovimentosPesagemDTO
    {
        public ESentido Sentido { get;  set; }
        public ETipoMovimento TipoMovimento { get;  set; }
        public EStatusMovimento StatusMovimento { get;  set; }
        public string Data { get;  set; }
        public Veiculos Veiculo { get;  set; }
        public Pessoas Motorista { get;  set; }
        public string Observacao { get;  set; }
        public double PesoChegada { get;  set; }
    }
}
