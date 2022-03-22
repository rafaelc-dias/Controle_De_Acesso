using ControleAcesso.Class;

namespace ControleAcesso.Domain.DTO
{
    public class SaidaCarroEmpresaSaidaDTO
    {
        public ESentido Sentido { get; private set; }
        public EStatusMovimento StatusMovimento { get;  set; }
        public DateTime Data { get; set; }
        public Guid VeiculoId { get;  set; }
        public Guid MotoristaId { get;  set; }
        public int KmSaida { get;  set; }
        public int NivelCombustivelSaida { get;  set; }
        public string HoraSaida { get;  set; }
        public string Destino { get;  set; }

        /*public SaidaCarroEmpresa ConverteSaidaCarroEmpresa()
        {
            return new SaidaCarroEmpresa(KmSaida, NivelCombustivelSaida, HoraSaida, Destino, Sentido, StatusMovimento, Data)
        }*/

    }
}
