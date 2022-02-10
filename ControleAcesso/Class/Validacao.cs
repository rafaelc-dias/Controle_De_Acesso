using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Validacao
    {
        public string ValidaDadosMov(string sentido,string data, string placa, string doc,string nome)
        {
            string msg = "";

            if ((string.IsNullOrEmpty(sentido)) || (sentido != "1") || (sentido != "2"))
            {
                msg = "Valor para Sentido inválido";
            }
            else if(!DateTime.TryParse(data, out DateTime validado))
            {
                msg = "Data informada inválida";
            }
            else if((string.IsNullOrEmpty(placa)) || (placa.Length > 7))
            {
                msg = "Valor para Sentido inválido";
            }
            else if((!Int64.TryParse(doc, out Int64 vld)) || (doc.Length > 11))
            {
                msg = "Valor para Documento inválido";
            }
            else if(string.IsNullOrEmpty(nome))
            {
                msg = "Valor para Nome inválido";
            }

            return msg;
            

        }


    }
}
