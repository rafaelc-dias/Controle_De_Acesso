﻿using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Class
{
    public class MovimentosPesagem : Movimentos
    {
        public List<NotasFiscais> NotasFiscais { get; private set; } = new();
        public double PesoChegada { get; private set; }
        public double PesoSaida { get; private set; }
        
        public string StatusPesagem { get; private set; }

        public MovimentosPesagem(double pesoChegada, ESentido sentido, ETipoMovimento tipoMovimento, EStatusMovimento statusMovimento, string data, Veiculos veiculo, Pessoas motorista, string observacao) : base(sentido, tipoMovimento, statusMovimento, data, veiculo, motorista, observacao)
        {
           PesoChegada = pesoChegada;

        }

        public void DefinePesosaida(double pesoSaida)
        {
            PesoSaida = pesoSaida;
        }

        public void IncluiNotaFiscalPesagem(NotasFiscaisDTO notasFiscaisDTO)
        {
            NotasFiscais notaFiscal = new(notasFiscaisDTO.IdMovimento, notasFiscaisDTO.NumeroNotaFiscal, notasFiscaisDTO.PesoNotaFiscal);

            NotasFiscais.Add(notaFiscal);

        }


        public void DefineStatusPesagem()
        {
            double totalPesoNotaFiscal = NotasFiscais.Sum(x => x.PesoNotaFiscal);

            if (((this.TipoMovimento == ETipoMovimento.RECEBIMENTO) && ((PesoChegada - PesoSaida) != totalPesoNotaFiscal)) || ((this.TipoMovimento == ETipoMovimento.EXPEDICAO) && ((PesoSaida - PesoChegada) != totalPesoNotaFiscal)))
            {
                StatusPesagem = "Pesagem bloqueada !!!";
            }
            else
            {
                StatusPesagem = "Pesagem liberda !!!";
            }
        }        

        public void Mostrardados()
        {
            Console.WriteLine($"Sentido =  {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome} - Peso Chegada = {PesoChegada} - Peso Saida = {PesoSaida}  - Status Pesagem = {StatusPesagem}");
        }

    }

   
}
