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
        public int Tipo { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private  set; }

        public Veiculos()
        {
            string veic;

            Console.WriteLine("Digite a Placa do veiculo:");
            veic = Console.ReadLine();

            if (String.IsNullOrEmpty(veic))
            {
                throw new Exception("Placa sem valor atribuido");
            }
            else
            {
                this.Placa = veic;
            }

            Console.WriteLine("Digite o Tipo do veiculo:");
            veic = Console.ReadLine();

            if (String.IsNullOrEmpty(veic))
            {
                throw new Exception("Tipo sem valor atribuido");
            }
            else
            {
                this.Tipo = Int16.Parse(veic);
            }

            Console.WriteLine("Digite a Marca do veiculo:");
            veic = Console.ReadLine();

            if (String.IsNullOrEmpty(veic))
            {
                throw new Exception("Marca sem valor atribuido");
            }
            else
            {
                this.Marca = veic;
            }

            Console.WriteLine("Digite a Modelo do veiculo:");
            veic = Console.ReadLine();

            if (String.IsNullOrEmpty(veic))
            {
                throw new Exception("Modelo sem valor atribuido");
            }
            else
            {
                this.Modelo = veic;
            }
        }

    }
}
