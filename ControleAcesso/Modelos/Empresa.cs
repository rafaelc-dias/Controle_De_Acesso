using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Empresa
    {
        public Guid Id { get; private set; }
        public string Cnpj { get; private set; }
        public string Nome { get; private set; }

        public Empresa(string cnpj, string nome)
        {
            Cnpj = cnpj;
            Nome = nome;            
        }
    }
}
