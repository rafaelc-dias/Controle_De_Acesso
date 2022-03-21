using ControleAcesso.Class;

namespace ControleAcesso.Domain.DTO
{
    public class EntradaFuncionarioDTO
    {
        public Guid Id { get;  set; }
        public ESentido Sentido { get;  set; }
        public EStatusMovimento StatusMovimento { get;  set; }
        public string Data { get;  set; }
        public Guid VeiculoId { get; set; }
        public Guid PessoaId { get; set; }

        
    }
}
