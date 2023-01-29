using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;


//é obrigatório implementar todos da interface aqui pq se não da erro
//é como se fosse um contrato que a interface tem com a classe
namespace ExemploPOO.models
{
    public class Calculadora : ICalculadora
    {
        
        public int Multiplicar (int num1, int num2)
        {
            return num1 * num2;
        }
        public int Somar (int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtrair (int num1, int num2)
        {
            return num1 - num2;
        }

    }
}