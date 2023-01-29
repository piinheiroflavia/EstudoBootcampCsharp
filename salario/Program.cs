// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;  

class minhaClasse { 

  static void Main(string[] args) {  

    double salario = 0.00; 
    double reajuste = 0.00; 
    double novoSalario = 0.00; 
    double percentual = 0.00; 
  
    salario = Convert.ToDouble(Console.ReadLine()); 

//TODO: Complete os espaços em branco com uma possível solução para o problema:
   
    if(salario > 0 && salario <= 400) 
    { 
      reajuste = salario*0.15; 
      novoSalario =  reajuste + salario ; 
      percentual = reajuste/salario ; 
      
      Console.WriteLine("Novo salario: {0:0.00}", novoSalario); 
      Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste ); 
      Console.WriteLine("Em percentual: {0} %", percentual * 100); 

    } else if (salario > 400.1 && salario <= 800) { 
      reajuste = salario * 0.12  ;         
      novoSalario =reajuste + salario ; 
      percentual = reajuste/salario; 
      
      Console.WriteLine("Novo salario: {0:0.00}", novoSalario); 
      Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste ); 
      Console.WriteLine("Em percentual: {0} %", percentual * 100); 

    } else if (salario > 800.1 && salario <= 1200) { 
      reajuste = salario * 0.10; 
      novoSalario = reajuste+ salario ; 
      percentual = reajuste / salario  ; 
      
      Console.WriteLine("Novo salario: {0:0.00}", novoSalario); 
      Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste ); 
      Console.WriteLine("Em percentual: {0} %", percentual * 100); 
      
    } else if (salario > 1200.1 && salario <= 2000) { 
      reajuste = salario * 0.07; 
      novoSalario =  reajuste + salario; 
      percentual = reajuste / salario ; 
      
      Console.WriteLine("Novo salario: {0:0.00}", novoSalario); 
      Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste ); 
      Console.WriteLine("Em percentual: {0} %", percentual * 100 ); 
    } 
    else
    {
      reajuste = salario * 0.04; 
      novoSalario = reajuste + salario ; 
      percentual = reajuste / salario; 

      Console.WriteLine("Novo salario: {0:0.00}", novoSalario); 
      Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste ); 
      Console.WriteLine("Em percentual: {0} %", percentual * 100 ); 
    }


  } 
}