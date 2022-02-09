using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Expedicao : Recebimento
    {

        public Expedicao(string nf, double pesoChegada, double pesoSaida, double pesoNf, int sentido, string data, Veiculos veic, Pessoas mot, string obs) : base(nf, pesoSaida, pesoChegada, pesoNf, sentido, data, veic, mot, obs)
        {
        }

        /*protected void ConferePesagemExp()
        {
            Double peso = this.PesoSaida - this.PesoChegada;

            if(peso != this.PesoNf)
            {
                this.StatusPesagem = "Pesagem bloqueada !!!";
            }
            else
            {
                this.StatusPesagem = "Pesagem liberda !!!";
            }
        }*/
    }
}
