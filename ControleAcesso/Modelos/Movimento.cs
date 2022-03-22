using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Class
{
    public abstract class Movimento
    {
        public Guid Id { get; private set; }
        public ESentido Sentido { get; private set; } 
        public EStatusMovimento StatusMovimento { get; private set; } = EStatusMovimento.ABERTO;
        public DateTime Data { get; private set; }
        public Veiculo Veiculo { get;  set; }
        public Pessoa Pessoa { get;  set; }
        public List<NotaFiscal> NotasFiscais { get; private set; } = new();
        public List<Observacao> Observacoes { get; private set; } = new();
              

        protected Movimento()
        {

        }
        
        public Movimento(ESentido sentido, DateTime data, Veiculo veiculo, Pessoa pessoa)
        {
            Sentido = sentido;
            Data = data;
            Veiculo = veiculo;
            Pessoa = pessoa;          
        }

        public void IncluirNotaFiscal(NotaFiscalDTO notasFiscaisDTO)
        {
            NotaFiscal notaFiscal = new(notasFiscaisDTO.IdMovimento, notasFiscaisDTO.NumeroNotaFiscal, notasFiscaisDTO.PesoNotaFiscal);

            NotasFiscais.Add(notaFiscal);

        }

        public void IncluirObservacao(ObservacaoDTO observacaoDTO)
        {
            Observacao observacao = new(observacaoDTO.IdMovimento,observacaoDTO.Obs);

            Observacoes.Add(observacao);

        }

        public void AlteraStatusFechado()
        {
            StatusMovimento = EStatusMovimento.FECHADO;
        }

        /*public void Mostrardados()
        {
            Console.WriteLine($"Sentido = {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome}");
        }*/
        


    }
}
