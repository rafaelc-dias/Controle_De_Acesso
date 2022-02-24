namespace ControleAcesso.Domain.Modelos
{
    public class NotasFiscais
    {
        public Guid Id { get; private set; }
        public Guid IdMovimento { get; private set; }
        public int NumeroNotaFiscal { get; private set; }
        public double PesoNotaFiscal { get; private set; }

        public NotasFiscais(Guid idMovimento, int numeroNotaFiscal, double pesoNotaFiscal)
        {
            IdMovimento = idMovimento;
            NumeroNotaFiscal = numeroNotaFiscal;
            PesoNotaFiscal = pesoNotaFiscal;
        }
    }
    

}
