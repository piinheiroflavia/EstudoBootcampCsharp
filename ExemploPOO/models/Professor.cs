using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    //sealed é quando faz um 'bloqueio' e não permite que a outra classe herda as propriedades
    //sealed significa que essa classe é a última instância final de uma herança de suas 'filhas'
    //niguém pode herdar mais essa classe
    //public sealed class Professor : Pessoa
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }
    }
}