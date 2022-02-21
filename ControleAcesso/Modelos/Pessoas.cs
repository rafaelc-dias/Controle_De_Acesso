using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Pessoas
    {
        public string Documento { get; private set; }
        public string Nome  { get; private set; }

        public Pessoas(string documento, string nome)
        {
            Documento = documento;
            Nome = nome;
        }

        public void AltearNomePessoa(string nome)
        {
            this.Nome = nome;
        }

        
    }
}
