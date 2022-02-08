using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    internal class Empresas
    {
        public string Cnpj { get; private set; }
        public string Nome { get; private set; }

        public Empresas(string cnpj, string nome)
        {
            Cnpj = cnpj;
            Nome = nome;
        }

        public Empresas( )
        {
            string cnpj;
            string nome;

            Console.WriteLine("Digite o CNPJ da Empresa:");
            cnpj = Console.ReadLine(); 

           if (String.IsNullOrEmpty(cnpj)){
                throw new Exception("CNPJ sem valor atribuido");
           }
           

            Console.WriteLine("Digite o Nome da Empresa:");
            nome = Console.ReadLine();

            if (String.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome sem valor atribuido");
            }

            this.Cnpj = cnpj;
            this.Nome = nome;
            

            
        }


    }
}
