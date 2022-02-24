using ControleAcesso.Class;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.DTO
{
    public class MovimentosPesagemPesoSaidaDTO
    {
        public Guid ID{ get;  set; }
        public double PesoSaida { get;  set; }
    }
}
