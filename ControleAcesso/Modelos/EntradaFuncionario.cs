namespace ControleAcesso.Class
{
    public class EntradaFuncionario : Movimento
    {
        protected EntradaFuncionario()
        {

        }
        
       public EntradaFuncionario(ESentido sentido, EStatusMovimento statusMovimento, string data, Veiculo veiculo, Pessoa pessoa) : base(sentido, statusMovimento, data, veiculo, pessoa)       
        {
        }

        

        /*public void Mostrardados()
        {
            Console.WriteLine($"Sentido = {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome}");
        }*/
    }

}

