using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class EntradaFuncionarios : Movimento
    {

        public EntradaFuncionarios(ESentido sentido, string data, Veiculos veic, Pessoas motorista, string obs) : base(sentido, data, veic, motorista, obs)
        {
        }

        public override void Mostrardados()
        {
            Console.WriteLine($"Sentido = {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome}");
        }
    }

}

