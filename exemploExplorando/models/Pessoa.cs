using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
public é plúblico para qualquer acesso para modificação na classe 
private só é permitido dentro da própria classe, não é acessivo externamente (somente a classe pode modificar)
*/
namespace exemploExplorando.models
{
    //propriedade 
    public class Pessoa
    {
        //todo construtor precisa ter o mesmo nome de uma classe
        //ele não precisa ter um retorno
        //ele pode ou não pode receber parâmetros
        public Pessoa()
        {

        }
        public Pessoa (string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        //(saí a string nome e entra sendo atríbuida por Nome )
        public void Deconstruct (out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        //esse aqui que vai guardar o nome
        private string _nome;
        private int _idade;
        public string Nome 
        { 
            /*get e set são propriedades
            o get retornara o nome 
            get
            {
                //o ToUpper converte as letras do nome para maiúscula
                return _nome.ToUpper();
            }*/

            get => _nome.ToUpper();
            set
            {
                //value é o argumento que tá recebendo o nome 
                if(value == "")
                {
                    //essa parte é uma exceção que o código criou 
                    //Exceção é algo que não permite que o código continua em excecução espera que alguém trate a exeção 
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            } 
        }

        public Pessoa(string sobrenome) 
        {
            this.Sobrenome = sobrenome;
   
        }
                public string Sobrenome {get; set;}

        public string NomeCompleto => Nome + Sobrenome.ToUpper();

        public int Idade 
        {  
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade é inválida");
                }
                _idade  = value;
            } 
        }

    public void Apresentar()
    {    
        Console.WriteLine($"Nome: {NomeCompleto} \n Idade: {Idade}");
    }

    }
}