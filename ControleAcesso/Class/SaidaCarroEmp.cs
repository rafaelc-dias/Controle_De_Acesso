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

        public SaidaCarroEmp(int kmSaida, int nvCombSaida, string horaSaida, string destino, int sentido, string data, Veiculos veic, Pessoas mot, string obs) : base(sentido, data, veic, mot, obs)
        {
            KmSaida = kmSaida;
            NvCombSaida = nvCombSaida;
            HoraSaida = horaSaida;
            Destino = destino;
        }
        public override void Mostrardados()
        {
            Console.WriteLine($"Sentido = {this.Sentido} - Data = {this.Data} - Placa = {this.Veic.Placa} - Pessoa = {this.Motorista.Nome} - KM Saida = {this.KmSaida} - Nivel Comb. = {this.NvCombSaida} - Hora Saida = {this.HoraSaida} - Destino = {this.Destino}");
        }

        /*public SaidaCarroEmp(string tipoPessoa) : base(tipoPessoa)
        {
            string kms;
            string nivcmbs;
            string hrs;
            string des;

            Console.WriteLine("**** REGISTRO DE MOVIMENTAÇÃO DOS CARROS DA EMPRESA ****\n");

            Console.WriteLine("Digite o KM de saida:");
            kms = Console.ReadLine();

            if (String.IsNullOrEmpty(kms))
            {
                throw new Exception("KM de saida sem valor atribuido");
            }
            

            Console.WriteLine("Digite o nivel de combustivel:");
            nivcmbs = Console.ReadLine();

            if (String.IsNullOrEmpty(nivcmbs))
            {
                throw new Exception("Nivel de combustivel sem valor atribuido");
            }
            

            Console.WriteLine("Digite a hora da saida:");
            hrs = Console.ReadLine();

            if (String.IsNullOrEmpty(hrs))
            {
                throw new Exception("Hora sem valor atribuido");
            }
            

            Console.WriteLine("Digite destino:");
            des = Console.ReadLine();

            if (String.IsNullOrEmpty(des))
            {
                throw new Exception("Destino sem valor atribuido");
            }

            this.KmSaida = Int32.Parse(kms);
            this.KmSaida = Int16.Parse(nivcmbs);
            this.HoraSaida = hrs;
            this.Destino = des;

        }*/


    }
}
