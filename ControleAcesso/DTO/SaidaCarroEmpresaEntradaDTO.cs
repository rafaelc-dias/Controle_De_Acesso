namespace ControleAcesso.Domain.DTO
{
    public class SaidaCarroEmpresaEntradaDTO
    {
        public Guid Id { get;  set; }
        public int KmEntrada { get;  set; }
        public int NivelCombustivelEntrada { get;  set; }
        public string HoraEntrada { get;  set; }
    }
}
