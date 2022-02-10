using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    internal class EntradaFunc : Movimento
    {

        public EntradaFunc(int sentido, string data, Veiculos veic, Pessoas motorista, string obs) : base(sentido, data, veic, motorista, obs)
        {
        }

        public override void Mostrardados()
        {
            Console.WriteLine($"Sentido = {Sent.GetValue(Sentido - 1)} - Data = {Data} - Placa = {Veic.Placa} - Pessoa = {Motorista.Nome}");
        }
    }

}

