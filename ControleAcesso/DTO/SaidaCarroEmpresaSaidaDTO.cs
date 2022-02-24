using ControleAcesso.Class;

namespace ControleAcesso.Domain.DTO
{
    public class SaidaCarroEmpresaSaidaDTO
    {
        public ESentido Sentido { get; private set; }
        public ETipoMovimento TipoMovimento { get;  set; }
        public EStatusMovimento StatusMovimento { get;  set; }
        public string Data { get; set; }
        public Veiculos Veiculo { get;  set; }
        public Pessoas Motorista { get;  set; }
        public string Observacao { get;  set; }
        public int KmSaida { get;  set; }
        public int NivelCombustivelSaida { get;  set; }
        public string HoraSaida { get;  set; }
        public string Destino { get;  set; }

    }
}
