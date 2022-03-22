using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Class
{
    public class MovimentoPesagem : Movimento
    {
        public double PesoChegada { get; private set; }
        public double PesoSaida { get; private set; }
        public double TotalPesoNotaFiscal { get; private set; }
        public string StatusPesagem { get; private set; }

        protected MovimentoPesagem()
        {
        }

        public MovimentoPesagem(double pesoChegada, ESentido sentido , DateTime data, Veiculo veiculo, Pessoa pessoa) : base(sentido,data, veiculo, pessoa)
        {
           PesoChegada = pesoChegada;

        }

        public void DefinePesosaida(double pesoSaida)
        {
            PesoSaida = pesoSaida;
        }

        /*public void DefineStatusPesagem()
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
