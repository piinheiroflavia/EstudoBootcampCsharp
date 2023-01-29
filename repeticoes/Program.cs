/*using System.Linq;
using System.Threading.Tasks;


namespace repeticoes
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}*/


/*int n = 5;

for (int numero = 0; numero <= 10; numero++)
{
    Console.WriteLine($"{numero} x {numero} = {numero * n}");
}
*/

/*
int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while (numero != 0);

Console.WriteLine(soma);

*/

using System;

string opcao;
bool exibirMenu = true;
while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - cadastrar: ");
    Console.WriteLine("2 - buscar: ");
    Console.WriteLine("3 - apagar: ");
    Console.WriteLine("4 - encerrar: ");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1" :
            Console.WriteLine("Cadastrar");
            exibirMenu = false;
            break;
        case "2" :  
            Console.WriteLine("Buscar");
            break;
        case "3" :
            Console.WriteLine("Apagar");
            break;
        case "4" :
            Console.WriteLine("encerrar");
            exibirMenu = false;
            //Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

Console.WriteLine("ola");