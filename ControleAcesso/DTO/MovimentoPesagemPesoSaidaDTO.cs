using ControleAcesso.Class;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.DTO
{
    public class MovimentoPesagemPesoSaidaDTO
    {
        public Guid ID{ get;  set; }
        public double PesoSaida { get;  set; }
    }
}
