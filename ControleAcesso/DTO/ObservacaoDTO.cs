namespace ControleAcesso.Domain.DTO
{
    public class ObservacaoDTO
    {
        public Guid Id { get; private set; }
        public Guid IdMovimento { get; private set; }
        public string Obs { get; private set; }
    }
}
