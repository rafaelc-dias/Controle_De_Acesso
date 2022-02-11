using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Expedicao : Recebimento
    {

        public Expedicao(string nf, double pesoSaida, double pesoChegada, double pesoNf, string sentido, string data, Veiculos veic, Pessoas mot, string obs) : base(nf, pesoSaida, pesoChegada, pesoNf, sentido, data, veic, mot, obs)
        {
        }

        public override void Mostrardados()
        {
            Console.WriteLine($"Sentido = {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome} - NF = {Nf} - Peso Chegada = {PesoSaida} - Peso Saida = {PesoChegada} - Peso NF = {PesoNf} - Status Pesagem = {StatusPesagem}");
        }
    }
}
