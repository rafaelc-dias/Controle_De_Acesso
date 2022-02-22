﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class EntradaFuncionarios : Movimento
    {
        
        public EntradaFuncionarios(ESentido sentido,ETipoMovimento etipoMovimento, string data, Veiculos veiculo, Pessoas motorista, string observacao) : base(sentido, etipoMovimento, data, veiculo, motorista, observacao)
        {
        }

        public void Mostrardados()
        {
            Console.WriteLine($"Sentido = {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome}");
        }
    }

}

