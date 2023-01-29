using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public abstract class Conta
    {
        //protege de alterações externa e só quem pode alterar são as classes filhas
        protected decimal saldo;
        //abstract ele não tem uma implementação (ex: uma implementação é o método ExibirSaldo, ele é um método, abre e fecha aspas
        // e foi implementado com o Console.WriteLine).
        //ele é
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo}");
        }
    }
}