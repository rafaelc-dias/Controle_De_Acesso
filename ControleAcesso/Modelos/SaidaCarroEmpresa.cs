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
        public int KmEntrada { get; private set; }
        public int NivelCombustivelEntrada { get; private set; }
        public string HoraEntrada { get; private set; }
        public string Destino { get; private set; }

        protected SaidaCarroEmpresa()
        {

        }

        public SaidaCarroEmpresa(int kmSaida, int nivelCombustivelSaida, string horaSaida, string destino, DateTime data, Veiculo veiculo, Pessoa pessoa) : base(ESentido.SAIDA, data, veiculo, pessoa)
        {
            KmSaida = kmSaida;
            NivelCombustivelSaida = nivelCombustivelSaida;
            HoraSaida = horaSaida;
            Destino = destino;
        }

        public void InserirDadosEntrada(int kmEntrada, int nivelCombustivelEntrada, string horaEntrada)
        {
            this.KmEntrada = kmEntrada;
            this.NivelCombustivelEntrada = nivelCombustivelEntrada;
            this.HoraEntrada = horaEntrada;

        }

        /*public void Mostrardados()
        {
            Console.WriteLine($"Sentido =  {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome} - KM Saida = {KmSaida} - Nivel Comb. = {NivelCombustivelSaida} - Hora Saida = {HoraSaida} - Destino = {Destino}");
        }*/

        


    }
}
