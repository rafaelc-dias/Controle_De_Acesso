using ControleAcesso.Class;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.DTO
{
    public class MovimentoPesagemDTO
    {
        public ESentido Sentido { get;  set; }
        public ETipoMovimentoPesagem TipoMovimento { get;  set; }
        public EStatusMovimento StatusMovimento { get;  set; }
        public string Data { get;  set; }
        public Veiculo Veiculo { get;  set; }
        public Pessoa Motorista { get;  set; }
        public string Observacao { get;  set; }
        public double PesoChegada { get;  set; }
    }
}
