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

        public Veiculos()
        {
            string placa;
            string modelo;

            Console.WriteLine("Digite a Placa do veiculo:");
            placa = Console.ReadLine();

            if (String.IsNullOrEmpty(placa))
            {
                throw new Exception("Placa sem valor atribuido");
            }
                  

            Console.WriteLine("Digite a Modelo do veiculo:");
            modelo = Console.ReadLine();

            if (String.IsNullOrEmpty(modelo))
            {
                throw new Exception("Modelo sem valor atribuido");
            }
            
            this.Placa = placa;
            this.Modelo = modelo;
            
        }

    }
}
