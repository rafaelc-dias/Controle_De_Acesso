using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Veiculo
    {
        public Guid Id { get; private set; }
        public string Placa { get; private set; }        
        public string Modelo { get; private  set; }

        public Veiculo(Guid id, string placa, string modelo)
        {
            Id = id;
            Placa = placa;
            Modelo = modelo;
        }

        public void AlterarModeloVeiculo(string modelo)
        {
            this.Modelo = modelo;
        }

    }
}
