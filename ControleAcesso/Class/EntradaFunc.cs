using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    internal class EntradaFunc : Movimento
    {
        public EntradaFunc() : base()
        {
            string func;

            Console.WriteLine("**** REGISTRO DE MOVIMENTAÇÃO DOS CARROS DOS FUNCIONARIOS ****\n");

            Console.WriteLine("Digite sentido (1 - Entrada/2 - Saida:");
            func = Console.ReadLine();

            if (String.IsNullOrEmpty(func))
            {
                throw new Exception("Sentido sem valor atribuido");
            }
            else
            {
                this.Sentido = Int16.Parse(func);
            }

            Console.WriteLine("Digite a data:");
            func = Console.ReadLine();

            if (String.IsNullOrEmpty(func))
            {
                throw new Exception("Data sem valor atribuido");
            }
            else
            {
                this.Data = func;
            }

            Veiculos veic = new Veiculos();

            Pessoas mot = new Pessoas("funcionario");    

            Console.WriteLine("Digite uma observacao:");
            this.Obs = Console.ReadLine();   

            
        }



    }

}

