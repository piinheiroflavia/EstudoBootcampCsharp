using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            //instânciando
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        //2 propriedades
        public int NumeroConta { get; set; }
        //privado fica vísivel apenas dentro da class
        //Encapsulamento protege o saldo e só atravês de um método ele fica disponível
        private decimal saldo;

        //método (ação)
        public void Sacar(decimal valor)
        {
            if(saldo >= valor)
            {
            saldo -= valor;
            Console.WriteLine("saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("saque indisponível");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponíve é: {saldo}");
        }
    }
}