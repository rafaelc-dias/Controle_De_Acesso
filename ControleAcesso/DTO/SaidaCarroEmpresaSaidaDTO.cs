using ControleAcesso.Class;

namespace ControleAcesso.Domain.DTO
{
    public class SaidaCarroEmpresaSaidaDTO
    {
        public ESentido Sentido { get; private set; }
        public EStatusMovimento StatusMovimento { get;  set; }
        public DateTime Data { get; set; }
        public Guid VeiculoId { get;  set; }
        public Guid PessoaId { get;  set; }
        public int KmSaida { get;  set; }
        public int NivelCombustivelSaida { get;  set; }
        public string HoraSaida { get;  set; }
        public string Destino { get;  set; }

        

    }
}
