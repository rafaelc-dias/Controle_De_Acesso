using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Validacao
    {
        public string ValidaDadosMovimento(string sentido,string data, string placa, string doc,string nome)
        {
            string msg = "";

            if ((string.IsNullOrEmpty(sentido)) || ((sentido != "1") && (sentido != "2")))
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

        public string ValidaDadosPesoNf(string nf, string pesocgd, string pesosai, string pesonf)
        {
            string msg = "";

            if ((string.IsNullOrEmpty(nf)) || (!Int64.TryParse(nf, out Int64 vld)))
            {
                msg = "Valor para Numero da Nota inválido";
            }
            else if ((string.IsNullOrEmpty(pesocgd)) || (!Double.TryParse(pesocgd, out Double vlpesocgd)))
            {
                msg = "Peso de chegada inválido";
            }
            else if ((string.IsNullOrEmpty(pesosai)) || (!Double.TryParse(pesosai, out Double vlpesosai)))
            {
                msg = "Valor para Sentido inválido";
            }
            else if ((string.IsNullOrEmpty(pesonf)) || (!Double.TryParse(pesonf, out Double vlpesonf)))
            {
                msg = "Valor para Documento inválido";
            }
            

            return msg;


        }

        public string ValidaDadosSaidaCarroEmpresa(string kms, string nivcmbs, string hrs, string destino)
        {
            string msg = "";

            if ((string.IsNullOrEmpty(kms)) || (!Int64.TryParse(kms, out Int64 vld)))
            {
                msg = "Valor Km de saida inválido";
            }
            else if ((string.IsNullOrEmpty(nivcmbs)) || (!Int64.TryParse(nivcmbs, out Int64 vlnivcmbs)))
            {
                msg = "Valor para Nivel de Combustivel inválido";
            }
            else if ((string.IsNullOrEmpty(hrs)) || (!TimeOnly.TryParse(hrs, out TimeOnly vlhrs)))
            {
                msg = "Valor para hora de saida inválido";
            }
            else if (string.IsNullOrEmpty(destino))
            {
                msg = "Valor para Destino inválido";
            }
                        
            return msg;

        }


    }
}
