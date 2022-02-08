using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    internal class EntradaFunc : Movimento
    {

        
        /*public EntradaFunc(string tipoPessoa) : base(tipoPessoa)
        {
            Console.WriteLine("**** REGISTRO DE MOVIMENTAÇÃO DOS CARROS DOS FUNCIONARIOS ****\n"); 

            
        }*/

        public EntradaFunc(int sentido, string data, Veiculos veic, Pessoas motorista, string obs) : base(sentido, data, veic, motorista, obs)
        {
        }
    }

}

