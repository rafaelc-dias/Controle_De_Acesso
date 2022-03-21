namespace ControleAcesso.Class
{
    public class EntradaFuncionario : Movimento
    {
        public DateTime DataSaida { get; private set; }
        protected EntradaFuncionario()
        {

        }
        
       public EntradaFuncionario(ESentido sentido, EStatusMovimento statusMovimento, DateTime dataEntrada, Veiculo veiculo, Pessoa pessoa) : base(sentido, statusMovimento, dataEntrada, veiculo, pessoa)       
        {
            
        }

        public void AdicionaDataSaida()
        {
            DataSaida = DateTime.Now;
        }
        

        /*public void Mostrardados()
        {
            Console.WriteLine($"Sentido = {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome}");
        }*/
    }

}

