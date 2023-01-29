using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        //métodos que não tem corpo é obrigatório para a implementação na classe
        int Multiplicar(int num1, int num2);

        //método que não tem corpo não é obrigatório para a implementação
        public int Dividir (int num1, int num2)
        {
            return num1 / num2;
        }
    }
}