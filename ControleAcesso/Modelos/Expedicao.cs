using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Expedicao : Recebimento
    {

        public Expedicao(string nf, double pesoSaida, double pesoChegada, double pesoNf, ESentido eSentido,  DateTime data, Veiculo veic, Pessoa pessoa) : base(nf, pesoSaida, pesoChegada, pesoNf, eSentido, data, veic, pessoa)
        {
        }

        /*public void Mostrardados()
        {
            Console.WriteLine($"Sentido = {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome} - NF = {Nf} - Peso Chegada = {PesoSaida} - Peso Saida = {PesoChegada} - Peso NF = {PesoNf} - Status Pesagem = {StatusPesagem}");
        }*/
    }
}
