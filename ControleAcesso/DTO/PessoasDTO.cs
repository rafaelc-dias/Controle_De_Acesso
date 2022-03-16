using ControleAcesso.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Domain.DTO
{
    public class PessoasDTO
    {
        public Guid Id { get;  set; }
        public string Documento { get;  set; }
        public string Nome { get; set; }
    
        public Pessoas ConverterPessoa()
        {
            var pessoa = new Pessoas(Id, Documento, Nome);
            return pessoa;
        }
    
    
    
    
    }


}
