using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//realizando o tratamento da 
/*
na prática ele vai pelo método 1 segue pelo 2 e 3 quando chega no quantro ele faz uma leitura
invertida e procura qual método vai ter a condição de tratar a exceção, no caso do ex vai o método 1,
pois ele possui o try e catch para a apresentar a leitura
*/
namespace exemploExplorando.models
{
    public class ExExcecao
    {
        public void metodo1()
        {
            try
            {
                metodo2();
            }catch(Exception)
            {
                Console.WriteLine("Exceção tratada");
            }
        }
        public void metodo2()
        {
            
        }
        public void metodo3()
        {
            
        }
        public void metodo4()
        {
            throw new Exception("Ocorreu uma tratamento");           
        }
    }
}