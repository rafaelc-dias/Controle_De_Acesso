using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    abstract public class Movimento
    {
        public int Sentido { get; set; }
        public string Data { get; set; }
        public Veiculos Veic { get; set; }
        public Pessoas Motorista { get; set; }
       public string Obs { get; set; }

       //public abstract void ConferePesagem(Double peso1, Double peso2, Double pesoNf);
    }
}
