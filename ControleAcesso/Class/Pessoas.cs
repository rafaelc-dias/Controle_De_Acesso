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
            string doc;
            string nome;

            Console.WriteLine($"Digite o Documento do {TipoPessoa}:");
            doc = Console.ReadLine();

            if (String.IsNullOrEmpty(doc))
            {
                throw new Exception("Documento sem valor atribuido");
            }
            

            Console.WriteLine($"Digite o Nome do {TipoPessoa}:");
            nome = Console.ReadLine();

            if (String.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome sem valor atribuido");
            }
            
            this.Documento = (int)Int64.Parse(doc);
            this.Nome = nome;
            


        }
    }
}
