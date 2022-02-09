using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Veiculos
    {
        public string Placa { get; private set; }        
        public string Modelo { get; private  set; }

        public Veiculos(string placa, string modelo)
        {
            Placa = placa;
            Modelo = modelo;
        }

    }
}
