using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class SaidaCarroEmp : Movimento
    {
        public int KmSaida { get; private set; }
        public int NvCombSaida { get; private set; }
        public string HoraSaida { get; private set; }
        public string Destino { get; private set; }

        public SaidaCarroEmp() : base()
        {
            string func;

            Console.WriteLine("**** REGISTRO DE MOVIMENTAÇÃO DOS CARROS DA EMPRESA ****\n");

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

            Console.WriteLine("Digite o KM de saida:");
            func = Console.ReadLine();

            if (String.IsNullOrEmpty(func))
            {
                throw new Exception("KM de saida sem valor atribuido");
            }
            else
            {
                this.KmSaida = Int32.Parse(func);
            }

            Console.WriteLine("Digite o nivel de combustivel:");
            func = Console.ReadLine();

            if (String.IsNullOrEmpty(func))
            {
                throw new Exception("Nivel de combustivel sem valor atribuido");
            }
            else
            {
                this.KmSaida = Int16.Parse(func);
            }

            Console.WriteLine("Digite a hora da saida:");
            func = Console.ReadLine();

            if (String.IsNullOrEmpty(func))
            {
                throw new Exception("Hora sem valor atribuido");
            }
            else
            {
                this.HoraSaida = func;
            }

            Console.WriteLine("Digite destino:");
            func = Console.ReadLine();

            if (String.IsNullOrEmpty(func))
            {
                throw new Exception("Destino sem valor atribuido");
            }
            else
            {
                this.Destino = func;
            }




        }
    }
}
