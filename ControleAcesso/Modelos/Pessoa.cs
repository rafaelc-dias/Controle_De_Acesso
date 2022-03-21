using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Pessoa
    {
        public Guid Id { get; private set; }
        public string Documento { get; private set; }
        public string Nome  { get; private set; }

        public Pessoa(Guid id,string documento, string nome)
        {
            Id = id;
            Documento = documento;
            Nome = nome;
        }

        public void AltearNomePessoa(string nome)
        {
            this.Nome = nome;
        }

        
    }
}
