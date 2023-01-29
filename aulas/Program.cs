// See https://aka.ms/new-console-template for more information

//ponto de entrada do programa
// posso ter várias cópias da classe, mas o namespace deles precisam ser diferente
//Console.WriteLine("Hello, World!");


//AULA SOBRE ARRAY
//usar sempre uma lista ao invés de um array por causa da capacidade que é maior 
//lista = não precisa passar a quantidade que desejo, porém ele trabalha internamento com um array
//array = é mais manual, precisa se preocupar com a quantidade de elementos que vai adicionar
//e não misturar a capacidade dele

List<string> listaString = new List<string>();

listaString.Add("RJ");
listaString.Add("MG");
listaString.Add("CE");






for ( int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posição: {i} - {listaString[i]}");
}
Console.WriteLine("PECORRENDO UMA ARRAY COM FOREACH");
int contadorForeach = 0;
foreach(string valor in listaString)
{
     Console.WriteLine($"Posição: {contadorForeach} - {valor}");
    contadorForeach++;
}









// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 42;
// arrayInteiros[1] = 62;
// arrayInteiros[2] = 82;
// arrayInteiros[3] = 72;

// int[] arrayInteiroDobrado = new int [arrayInteiros.Length*2];
// Array.Copy(arrayInteiros,arrayInteiroDobrado,arrayInteiros.Length);

// Console.WriteLine("PECORRENDO UMA ARRAY COM O FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição: {contador} - {arrayInteiros [contador]}");
// }








//FOREACH SÓ FUNCIONA COLOCAR A POSIÇÃO|| O FOREACH SÓ FUNCIONAR EM CASOS DE LISTA.
// int contadorForeach = 0;
// Console.WriteLine("PECORRENDO UMA ARRAY COM FOREACH");
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição: {contadorForeach} - {valor}");
// }










//DataTime dataAtual = DataTime.Now;

//Pessoa p = new Pessoa();

//p.PessoaNome = "Ana";
//p.Idade = 22;

//p.Apresentar();


//OPERADORES
// int a = 10;
// int b = 12;

// int c = a + b;
// //c = c + 5;
// c += 5;
// Console.WriteLine(c);

//TRABLHANDO COM CONVERTE

// int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// Console.WriteLine(a);

//CONDICIONAL
// int quantidadeEmEstoque= 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {quantidadeEmEstoque}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Compra feita");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Veanda realiza");
// }
// else
// {
//     Console.WriteLine("Desculpe. Compra não aceita");
// }


//CONDIÇÃO DE CASE

//Console.WriteLine("Digite uma Letra");
// string letra = Console.ReadLine();

// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }



//  int value1 = ;
//   int value2 = ;

//cal.Somar(5,8);
// cal.Subtrair(10, 52);
// cal.Multiplicar(4, 8);
// cal.Dividir(9,2);
// cal.Potencia(9,2);

/*
namespace aula_c_.models
{
     static void Main (string[] argus)
        {
            CalculadoraA cal = new CalculadoraA();
     
            //criando variáveis que vão conter os valores
            // com letras minusculas para diferenciar que das variaves da classe
            int numero1;
            int numero2;
            int resultado;
            string operacao;

            Console.WriteLine("Digite o primeiro número número: ");
            numero1 = Console.ReadLine();

            Console.WriteLine("soma \n subtrair \n /multiplicar \n dividir");
            Console.WriteLine("Digite a operação deseja: ");
            operacao = Console.ReadLine();
            
            Console.WriteLine("Digite o segundo número número: ");
            numero2 = Console.ReadLine();

            cal.Numero1 = numero1

        }
}
*/

/*int n = 5;

for (int numero = 0; numero <= 10; numero++)
{
    int tabu = n * numero;
    
}
Console.WriteLine({n} "x" {numero} "=" {tabu});*/