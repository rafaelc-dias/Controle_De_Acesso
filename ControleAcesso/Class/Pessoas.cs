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

        public Pessoas(int documento, string nome)
        {
            Documento = documento;
            Nome = nome;
        }

        
    }
}
