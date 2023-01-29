using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    //Herança reaproveitar uma classe já existente
    //não precisa repetir código, reaproveito da classe Pessoa e só adiciona objetos que não possui lá
    public class Aluno : Pessoa
    {
        public decimal Nota { get; set; }
    }
/*
//polimorfismo quando utilizar o mesmo método em classe diferentes
    public override void Apresentar()
    {
        Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e minha note é {Nota}");
    }
*/
}