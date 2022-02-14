using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    abstract public class Movimento
    {
        public ESentido Sentido { get; private set; }
        public string Data { get; private set; }
        public Veiculos Veiculo { get; private set; }
        public Pessoas Motorista { get; private set; }
        public string Observacao { get; private set; }       

        protected Movimento(ESentido sentido, string data, Veiculos veiculo, Pessoas motorista, string observacao)
        {
            Sentido = sentido;
            Data = data;
            Veiculo = veiculo;
            Motorista = motorista;
            Observacao = observacao;

           
        }

        public abstract void Mostrardados();
        


    }
}
