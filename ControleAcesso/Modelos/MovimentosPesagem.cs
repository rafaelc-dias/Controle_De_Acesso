using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Class
{
    public class MovimentosPesagem : Movimentos
    {
        public double PesoChegada { get; private set; }
        public double PesoSaida { get; private set; }
        public double TotalPesoNotaFiscal { get; private set; }
        public string StatusPesagem { get; private set; }

        protected MovimentosPesagem()
        {
        }

        public MovimentosPesagem(double pesoChegada, ESentido sentido, ETipoMovimento tipoMovimento, EStatusMovimento statusMovimento, string data, Veiculos veiculo, Pessoas pessoa) : base(sentido, tipoMovimento, statusMovimento, data, veiculo, pessoa)
        {
           PesoChegada = pesoChegada;

        }

        public void DefinePesosaida(double pesoSaida)
        {
            PesoSaida = pesoSaida;
        }

        public void DefineStatusPesagem()
        {
            TotalPesoNotaFiscal = NotasFiscais.Sum(x => x.PesoNotaFiscal);

            if (((TipoMovimento == ETipoMovimento.RECEBIMENTO) && ((PesoChegada - PesoSaida) != TotalPesoNotaFiscal)) || ((TipoMovimento == ETipoMovimento.EXPEDICAO) && ((PesoSaida - PesoChegada) != TotalPesoNotaFiscal)))
            {
                StatusPesagem = "Pesagem bloqueada !!!";
            }
            else
            {
                StatusPesagem = "Pesagem liberda !!!";
            }
        }        

        /*public void Mostrardados()
        {
            Console.WriteLine($"Sentido =  {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome} - Peso Chegada = {PesoChegada} - Peso Saida = {PesoSaida}  - Status Pesagem = {StatusPesagem}");
        }*/

    }

   
}
