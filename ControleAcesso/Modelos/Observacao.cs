namespace ControleAcesso.Domain.Modelos
{
    public class Observacao
{
    public Guid Id { get; private set; } 
    public Guid IdMovimento { get; private set; }
    public string Obs { get; private set; }
    

    public Observacao(Guid idMovimento, string obs)
    {
        IdMovimento = idMovimento;
        Obs = obs;  
       
    }
}
    

}
