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

        


    }
}
