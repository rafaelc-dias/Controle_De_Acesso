using ControleAcesso.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Domain.DTO
{
    public class MovimentoDTO
    {
        public ESentido Sentido { get;  set; }
        public EStatusMovimento StatusMovimento { get;  set; }
        public string Data { get;  set; }
        public Veiculo Veiculo { get;  set; }
        public Pessoa Pessoa { get;  set; }

        public EntradaFuncionario ConverteEntradaFuncionario()
        {
            EntradaFuncionario entradaFuncionario = new(Sentido, StatusMovimento, Data, Veiculo, Pessoa);
            return entradaFuncionario;
        }

    }

    
}
