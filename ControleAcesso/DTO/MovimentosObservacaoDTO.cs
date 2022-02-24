using ControleAcesso.Class;

namespace ControleAcesso.Domain.DTO
{
    public class MovimentosObservacaoDTO
    {
        public Guid Id { get; set; }
        public ETipoMovimento TipoMovimento { get;  set; }
        public string Observacao { get; set; }

        
    }

    
}
