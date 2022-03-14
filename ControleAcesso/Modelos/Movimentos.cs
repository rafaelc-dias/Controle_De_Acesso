using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Movimentos
    {
        public Guid Id { get; private set; }
        public ESentido Sentido { get; private set; }
        public ETipoMovimento TipoMovimento {get; private set;}
        public EStatusMovimento StatusMovimento { get; private set;}
        public string Data { get; private set; }
        public Veiculos Veiculo { get;  set; }
        public Pessoas Pessoa { get;  set; }
        public List<NotasFiscais> NotasFiscais { get; private set; } = new();
        public List<Observacao> Observacoes { get; private set; } = new();

        protected Movimentos()
        {

        }
        
        public Movimentos(ESentido sentido, ETipoMovimento tipoMovimento, EStatusMovimento statusMovimento, string data, Veiculos veiculo, Pessoas pessoa)
        {
            Sentido = sentido;
            TipoMovimento = tipoMovimento;
            StatusMovimento = statusMovimento;
            Data = data;
            Veiculo = veiculo;
            Pessoa = pessoa;          
        }

        public void IncluirNotaFiscal(NotasFiscaisDTO notasFiscaisDTO)
        {
            NotasFiscais notaFiscal = new(notasFiscaisDTO.IdMovimento, notasFiscaisDTO.NumeroNotaFiscal, notasFiscaisDTO.PesoNotaFiscal);

            NotasFiscais.Add(notaFiscal);

        }

        public void IncluirObservacao(ObservacaoDTO observacaoDTO)
        {
            Observacao observacao = new(observacaoDTO.IdMovimento,observacaoDTO.Obs);

            Observacoes.Add(observacao);

        }

        /*public void Mostrardados()
        {
            Console.WriteLine($"Sentido = {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome}");
        }*/
        


    }
}
