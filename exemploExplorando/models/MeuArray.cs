using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//o T funciona com uma classe genérica
namespace exemploExplorando.models
{
    public class MeuArray<T>
    {
        //capacidade maxima do array é de 10
        private static int capacidade = 10;
        private int contador = 0;
        // T (um tipo genérico para o array)
        private T[] array = new T[10];

        //criando um método com um contador para adicionar os elementos (números) dentro do array
        public void AdicionarElementoArray( T elemento)
        {
            if (contador + 1 < 11 )
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get {return array[index]; }
            set {array[index] = value; }            
        }
    }
}