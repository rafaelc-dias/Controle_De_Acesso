﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class MovimentoPesagem : Movimento
    {
        public string Nf { get; private set; }
        public double PesoChegada { get; private set; }
        public double PesoSaida { get; private set; }
        public double PesoNf { get; private set; }
        public string StatusPesagem { get; private set; }

        public MovimentoPesagem(string nf, double pesoChegada, double pesoSaida, double pesoNf, ESentido sentido, ETipoMovimento tipoMovimento, EStatusMovimento statusMovimento, string data, Veiculos veiculo, Pessoas motorista, string obs) : base(sentido, tipoMovimento, statusMovimento, data, veiculo, motorista,  obs)
        {
            Nf = nf;
            PesoChegada = pesoChegada;
            PesoSaida = pesoSaida;
            PesoNf = pesoNf;

            

            if (((tipoMovimento == ETipoMovimento.RECEBIMENTO) && ((PesoChegada - PesoSaida) != PesoNf)) || ((tipoMovimento == ETipoMovimento.EXPEDICAO) && ((PesoSaida - PesoChegada) != PesoNf)))
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
            Console.WriteLine($"Sentido =  {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome} - NF = {Nf} - Peso Chegada = {PesoChegada} - Peso Saida = {PesoSaida} - Peso NF = {PesoNf} - Status Pesagem = {StatusPesagem}");
        }

    }

   
}