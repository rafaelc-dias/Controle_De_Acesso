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

        public Movimento(string tipoPessoa)
        {
            string sentido;
            string data;
            
            Console.WriteLine("Digite sentido (1 - Entrada/2 - Saida:");
            sentido = Console.ReadLine();

            if (String.IsNullOrEmpty(sentido))
            {
                throw new Exception("Sentido sem valor atribuido");
            }
            

            Console.WriteLine("Digite a data:");
            data = Console.ReadLine();

            if (String.IsNullOrEmpty(data))
            {
                throw new Exception("Data sem valor atribuido");
            }
          

            Veiculos veic = new Veiculos();

            Pessoas mot = new Pessoas(tipoPessoa);

            Console.WriteLine("Digite uma observacao:");
            this.Obs = Console.ReadLine();

            this.Sentido = Int16.Parse(sentido);
            this.Data = data;
            
        }

       //public abstract void ConferePesagem(Double peso1, Double peso2, Double pesoNf);
    }
}
