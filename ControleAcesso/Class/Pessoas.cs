using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Pessoas
    {
        public int Documento { get; private set; }
        public string Nome  { get; private set; }

        public Pessoas(string TipoPessoa)
        {
            string pes;

            Console.WriteLine($"Digite o Documento do {TipoPessoa}:");
            pes = Console.ReadLine();

            if (String.IsNullOrEmpty(pes))
            {
                throw new Exception("Documento sem valor atribuido");
            }
            else
            {
                this.Documento = (int)Int64.Parse(pes) ;
            }

            Console.WriteLine($"Digite o Nome do {TipoPessoa}:");
            pes = Console.ReadLine();

            if (String.IsNullOrEmpty(pes))
            {
                throw new Exception("Nome sem valor atribuido");
            }
            else
            {
                this.Nome = pes;
            }


        }
    }
}
