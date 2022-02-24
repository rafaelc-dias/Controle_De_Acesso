using ControleAcesso.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Domain.DTO
{
    public class MovimentosDTO
    {
        public ESentido Sentido { get;  set; }
        public ETipoMovimento TipoMovimento { get;  set; }
        public EStatusMovimento StatusMovimento { get;  set; }
        public string Data { get;  set; }
        public Veiculos Veiculo { get;  set; }
        public Pessoas Motorista { get;  set; }
        public string Observacao { get;  set; }
    }
}
