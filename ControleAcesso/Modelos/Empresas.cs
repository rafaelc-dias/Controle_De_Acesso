using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Empresas
    {
        public string Cnpj { get; private set; }
        public string Nome { get; private set; }

        public Empresas(string cnpj, string nome)
        {
            Cnpj = cnpj;
            Nome = nome;            
        }
    }
}
