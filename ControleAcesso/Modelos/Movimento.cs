﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class Movimento
    {
        public Guid Id { get; set; }
        public ESentido Sentido { get; private set; }
        public ETipoMovimento TipoMovimento {get; private set;}
        public EStatusMovimento StatusMovimento { get; private set;}
        public string Data { get; private set; }
        public Veiculos Veiculo { get; private set; }
        public Pessoas Motorista { get; private set; }
        public string Observacao { get; private set; }       

        public Movimento(ESentido sentido, ETipoMovimento tipoMovimento, EStatusMovimento statusMovimento, string data, Veiculos veiculo, Pessoas motorista, string observacao)
        {
            Sentido = sentido;
            TipoMovimento = tipoMovimento;
            StatusMovimento = statusMovimento;
            Data = data;
            Veiculo = veiculo;
            Motorista = motorista;
            Observacao = observacao;

           
        }

        public void Mostrardados()
        {
            Console.WriteLine($"Sentido = {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome}");
        }
        


    }
}
