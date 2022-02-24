using ControleAcesso.Class;

namespace ControleAcesso.Domain.DTO
{
    public class SaidaCarroEmpresaSaidaDTO
    {
        public ESentido Sentido { get; private set; }
        public ETipoMovimento TipoMovimento { get; private set; }
        public EStatusMovimento StatusMovimento { get; private set; }
        public string Data { get; private set; }
        public Veiculos Veiculo { get; private set; }
        public Pessoas Motorista { get; private set; }
        public string Observacao { get; private set; }
        public int KmSaida { get; private set; }
        public int NivelCombustivelSaida { get; private set; }
        public string HoraSaida { get; private set; }
        public string Destino { get; private set; }

    }
}
