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

        /* public Recebimento() : base()
         {
             string nf;
             string pesocgd;
             string pesosai;
             string pesonf;

             Console.WriteLine("**** REGISTRO DE MOVIMENTAÇÃO DE RECEBIMENTO ****\n");

             Console.WriteLine("Digite o numero da NF:");
             nf = Console.ReadLine();

             if (String.IsNullOrEmpty(nf))
             {
                 throw new Exception("KM de saida sem valor atribuido");
             }


             Console.WriteLine("Digite o peso de chegada do caminhao");
             pesocgd = Console.ReadLine();

             if (String.IsNullOrEmpty(pesocgd))
             {
                 throw new Exception("Nivel de combustivel sem valor atribuido");
             }


             Console.WriteLine("Digite o peso de saida do caminha:");
             pesosai = Console.ReadLine();

             if (String.IsNullOrEmpty(pesosai))
             {
                 throw new Exception("Hora sem valor atribuido");
             }


             Console.WriteLine("Digite o peda da NF:");
             pesonf = Console.ReadLine();

             if (String.IsNullOrEmpty(pesonf))
             {
                 throw new Exception("Destino sem valor atribuido");
             }

             this.Nf = nf;
             this.PesoChegada = double.Parse(pesocgd);
             this.PesoSaida = double.Parse(pesosai);
             this.PesoNf = double.Parse(pesonf);
         }*/

        /*public void ConferePesagemRec()
        {
            Double peso = this.PesoChegada - this.PesoSaida;

            if (peso != this.PesoNf)
            {
                this.StatusPesagem = "Pesagem bloqueada !!!";
            }
            else
            {
                this.StatusPesagem = "Pesagem liberda !!!";
            }
        }*/

        public override void Mostrardados()
        {
            Console.WriteLine($"Sentido = {Sentido} - Data = {Data} - Placa = {Veic.Placa} - Pessoa = {Motorista.Nome} - NF = {Nf} - Peso Chegada = {PesoChegada} - Peso Saida = {PesoSaida} - Peso NF = {PesoNf} - Status Pesagem = {StatusPesagem}");
        }

    }

   
}
