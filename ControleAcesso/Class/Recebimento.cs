using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Recebimento : Movimento
    {
        public string Nf { get; set; }
        public double PesoChegada { get; set; }
        public double PesoSaida { get; set; }
        public double PesoNf { get; set; }

        public Recebimento(string nf, double pesoChegada, double pesoSaida, double pesoNf, int sentido, string data, Veiculos veic, Pessoas mot, string obs) : base( sentido, data ,veic,  mot,  obs)
        {
            Nf = nf;
            PesoChegada = pesoChegada;
            PesoSaida = pesoSaida;
            PesoNf = pesoNf;
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

        public void ConferePesagemRec()
        {
            Double peso = this.PesoChegada - this.PesoSaida;

            if (peso != this.PesoNf)
            {
                Console.WriteLine("Pesagem bloqueada !!!");
            }
            else
            {
                Console.WriteLine("Pesagem liberda !!!");
            }
        }

        public void Mostrardados()
        {
            Console.WriteLine($"Sentido = {this.Sentido} - Data = {this.Data} - Placa = {this.Veic.Placa} - Pessoa = {this.Motorista.Nome} - NF = {this.Nf} - Peso Chegada = {this.PesoChegada} - Peso Saida = {this.PesoSaida} - Peso NF = {this.PesoNf} ");
        }

    }

   
}
