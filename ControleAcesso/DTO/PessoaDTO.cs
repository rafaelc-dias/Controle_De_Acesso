using ControleAcesso.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Domain.DTO
{
    public class PessoaDTO
    {
        public Guid Id { get;  set; }
        public string Documento { get;  set; }
        public string Nome { get; set; }
    
        public Pessoa ConverterPessoa()
        {
            var pessoa = new Pessoa(Id, Documento, Nome);
            return pessoa;
        }
    
    
    
    
    }


}
