using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    abstract public class Movimento
    {
        public int Sentido { get; private set; }
        public string Data { get; private set; }
        public Veiculos Veic { get; private set; }
        public Pessoas Motorista { get; private set; }
        public string Obs { get; private set; }

        protected Movimento(int sentido, string data, Veiculos veic, Pessoas motorista, string obs)
        {
            Sentido = sentido;
            Data = data;
            Veic = veic;
            Motorista = motorista;
            Obs = obs;
        }

       
    }
}
