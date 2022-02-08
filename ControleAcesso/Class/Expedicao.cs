using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Expedicao : Recebimento
    {

        public Expedicao(string nf, double pesoChegada, double pesoSaida, double pesoNf, int sentido, string data, Veiculos veic, Pessoas mot, string obs) : base(nf, pesoChegada, pesoSaida, pesoNf, sentido, data, veic, mot, obs)
        {
        }

        protected void ConferePesagemExp()
        {
            Double peso = this.PesoSaida - this.PesoChegada;

            if (peso != this.PesoNf)
            {
                Console.WriteLine("Pesagem bloqueada !!!");
            }
            else
            {
                Console.WriteLine("Pesagem liberda !!!");
            }
        }
    }
}
