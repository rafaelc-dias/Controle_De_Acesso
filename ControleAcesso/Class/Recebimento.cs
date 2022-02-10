using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Recebimento : Movimento
    {
        public string Nf { get; private set; }
        public double PesoChegada { get; private set; }
        public double PesoSaida { get; private set; }
        public double PesoNf { get; private set; }
        public string StatusPesagem { get; private set; }

        public Recebimento(string nf, double pesoChegada, double pesoSaida, double pesoNf, int sentido, string data, Veiculos veic, Pessoas mot, string obs) : base( sentido, data ,veic,  mot,  obs)
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

        public override void Mostrardados()
        {
            Console.WriteLine($"Sentido =  {Sent.GetValue(Sentido - 1)} - Data = {Data} - Placa = {Veic.Placa} - Pessoa = {Motorista.Nome} - NF = {Nf} - Peso Chegada = {PesoChegada} - Peso Saida = {PesoSaida} - Peso NF = {PesoNf} - Status Pesagem = {StatusPesagem}");
        }

    }

   
}
