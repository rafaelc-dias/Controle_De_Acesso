using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Recebimento : Movimentos
    {
        public string Nf { get; private set; }
        public double PesoChegada { get; private set; }
        public double PesoSaida { get; private set; }
        public double PesoNf { get; private set; }
        public string StatusPesagem { get; private set; }

        public Recebimento(string nf, double pesoChegada, double pesoSaida, double pesoNf, ESentido eSentido, ETipoMovimento tipoMovimento, EStatusMovimento statusMovimento, string data, Veiculos veiculo, Pessoas pessoa) : base(eSentido, tipoMovimento, statusMovimento, data, veiculo, pessoa)
        {
            Nf = nf;
            PesoChegada = pesoChegada;
            PesoSaida = pesoSaida;
            PesoNf = pesoNf;

            if ((PesoChegada - PesoSaida) != PesoNf)
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
            Console.WriteLine($"Sentido =  {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome} - NF = {Nf} - Peso Chegada = {PesoChegada} - Peso Saida = {PesoSaida} - Peso NF = {PesoNf} - Status Pesagem = {StatusPesagem}");
        }*/

    }

   
}
