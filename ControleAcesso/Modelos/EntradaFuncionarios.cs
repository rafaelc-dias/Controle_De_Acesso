﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ControleAcesso.Class
{
    public class EntradaFuncionarios : Movimentos
    {
        
       public EntradaFuncionarios(ESentido sentido,ETipoMovimento etipoMovimento, EStatusMovimento statusMovimento, string data, Veiculos veiculo, Pessoas pessoa) : base(sentido, etipoMovimento, statusMovimento, data, veiculo, pessoa)       
        {
        }

        /*public void Mostrardados()
        {
            Console.WriteLine($"Sentido = {Sentido} - Data = {Data} - Placa = {Veiculo.Placa} - Pessoa = {Motorista.Nome}");
        }*/
    }

}

