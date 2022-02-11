using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class SaidaCarroEmpresa : Movimento
    {
        public int KmSaida { get; private set; }
        public int NivelCombustivelSaida { get; private set; }
        public string HoraSaida { get; private set; }
        public string Destino { get; private set; }

        public SaidaCarroEmpresa(int kmSaida, int nivelCombustivelSaida, string horaSaida, string destino, ESentido sentido, string data, Veiculos veiculo, Pessoas motorista, string observacao) : base(sentido, data, veiculo, motorista, observacao)
        {
            KmSaida = kmSaida;
            NivelCombustivelSaida = nivelCombustivelSaida;
            HoraSaida = horaSaida;
            Destino = destino;
        }
        public override void Mostrardados()
        {
            Console.WriteLine($"Sentido =  {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome} - KM Saida = {KmSaida} - Nivel Comb. = {NivelCombustivelSaida} - Hora Saida = {HoraSaida} - Destino = {Destino}");
        }

        


    }
}
