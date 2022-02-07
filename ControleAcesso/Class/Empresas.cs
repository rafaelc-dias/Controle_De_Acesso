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
        
        public Empresas( )
        {
            string emp;

            Console.WriteLine("Digite o CNPJ da Empresa:");
            emp = Console.ReadLine(); 

           if (String.IsNullOrEmpty(emp)){
                throw new Exception("CNPJ sem valor atribuido");
           }
           else
            {
                this.Cnpj = emp;
            }

            Console.WriteLine("Digite o Nome da Empresa:");
            emp = Console.ReadLine();

            if (String.IsNullOrEmpty(emp))
            {
                throw new Exception("Nome sem valor atribuido");
            }
            else
            {
                this.Nome = emp;
            }

            
        }


    }
}
