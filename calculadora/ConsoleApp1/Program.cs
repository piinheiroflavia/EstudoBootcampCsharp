using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora p = new();

           
            int operacao;
            int numero1;
            int numero2;

            Console.WriteLine("Qual operação deseja: \n (1)somar  \n (2)subtrair \n (3)multiplicar \n (4)dividir");
            operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro segundo número: ");
            numero2 = int.Parse(Console.ReadLine());


            p.Numero1 = numero1; 
            p.Numero2 = numero2;
            p.Operacao = operacao;
           
           

            p.imprimir();
        }
    }
}
