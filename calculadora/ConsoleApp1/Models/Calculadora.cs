using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Calculadora
    {
        public int Numero1;
        public int Numero2;
        public int Operacao;
        public int Resposta;

        public void imprimir()
        {
            switch (Operacao)
            {
                case 1:
                    Resposta = Numero1 + Numero2;
                    Console.WriteLine($"Resultado: {Numero1} + {Numero2} = {Resposta}");
                    break;
                case 2:
                    Resposta = Numero1 - Numero2;
                    Console.WriteLine($"Resultado: {Numero1} - {Numero2} = {Resposta}");
                    break ;
                case 3:
                    Resposta = Numero1 * Numero2;
                    Console.WriteLine($"Resultado: {Numero1} X {Numero2} = {Resposta}");
                    break;
                case 4:
                    Resposta = Numero1 / Numero2;
                    Console.WriteLine($"Resultado: {Numero1} / {Numero2} = {Resposta}");
                    break;
                default: 
                    Console.WriteLine("erro");
                    break;
            }

            
        }
    }
}