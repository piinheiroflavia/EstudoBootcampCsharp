using exemploExplorando.models;
using Newtonsoft.Json;




/*
//TIPOS SIMPLES - DADOS ESTÁTICOS - MEMÓRIAS STACK
int a = 10;
int b = a;

b = 60;

Console.WriteLine($"Valor de A: {a}");
Console.WriteLine($"Valor de B: {b}");

//TIPOS COMPLEXOS - DADOS DINÂMICOS - MEMÓRIAS HEAP
Pessoa p1 = new Pessoa();
Pessoa p2 = p1;
*/
















/*
MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);
Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("test");
Console.WriteLine(arrayString[0]);

*/












/*
//VARIÁVEIS DINÂNICO
dynamic varialvelDianamica = 3;
Console.WriteLine($"Tipo de variável: {varialvelDianamica.GetType()}, valor: {varialvelDianamica}");

varialvelDianamica = true;
Console.WriteLine($"Tipo de variável: {varialvelDianamica.GetType()}, valor: {varialvelDianamica}");

varialvelDianamica = "ana";
Console.WriteLine($"Tipo de variável: {varialvelDianamica.GetType()}, valor: {varialvelDianamica}");
*/








/*
// o ? significa q ele recebe outro tipo de valor adicional, além do true e false
bool ? desejaReceberEmail = null;
// ex: false - usuário não quer, true - usuário quer, null - usuário não visualizou ainda
//hasvalue verifica se é diferente de nulo e seguida o Value verifica se é verdadeiro
if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("Gostaria de receber um email");
}
else
{
    Console.WriteLine("Não gostaria de receber um email");
}

*/











/*
//DESERIALIZANDO O ARQUIVO JSON

string conteudoArquivo = File.ReadAllText("arquivo/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (var venda in listaVenda)
{
    Console.WriteLine($"\n Id: {venda.Id} \n Produto: {venda.Produto} \n " + 
    $"Preço: {venda.Preco} \n Data da Compra: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" + 
    $"{(venda.Desconto.HasValue? $" \n Desconto de {venda.Desconto}" : "  ")}");    
}

Console.WriteLine("----------------------------");

var listaAnonima = listaVenda.Select(x => new {x.Produto, x.Preco});

foreach (var venda in listaAnonima)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}

*/










/*

//CLASSE VENDA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploExplorando.models
{
    public class Venda
    {

        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        public int Id {get; set;}
        public string Produto {get; set;}
        public decimal Preco {get; set;}

        public DateTime DataVenda { get; set; }
    }

}   

//SERIALIZANDO O ARQUIVO JSON

DateTime dataAtual = DateTime.Now;
//lista com uma coleção de objetos
List<Venda> listaVendas = new List<Venda>();
//objeto
Venda v1 = new Venda( 1, "Caneta", 2.50M, dataAtual);
Venda v2 = new Venda( 2, "lapiseira", 5.50M, dataAtual);
Venda v3 = new Venda( 3, "borracha", 1.10M, dataAtual);
Venda v4 = new Venda( 4, "pincel", 10.50M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);
listaVendas.Add(v3);
listaVendas.Add(v4);

//transformando(criando) e formatando o objeto em um json
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("arquivo/vendas.json", serializado);

Console.WriteLine(serializado);

*/









/*
int numero = 10;
bool par = false;

par = numero.EhPar();

par = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (par ? "par" : "ímpar"));
*/










/*
//DECONSTRUCT - ESTÁ DESCONTRUÍDO ALGO QUE JÁ FOI CONSTRUÍDO UM EX É NA CLASSE PESSOA saí a 
//string nome e entra sendo atríbuida por Nome 
Pessoa p1 = new Pessoa("Ana", "Gomes ");
//está re
(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");
*/


















/*
LeituraArquivo arquivo = new LeituraArquivo();
//tuplas // criando variáveis e integrando a classe lerArquivo com a pasta arquivo 
//se for verdadeiro(sucesso)
//var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("arquivo/arquivo.txt");

// o _ funciona como um descarte
var (sucesso, linhasArquivo, _ ) = arquivo.LerArquivo("arquivo/arquivo.txt");


if (sucesso)
{
    //Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível fazer leitura do arquivo");
}
*/




















/*
//UTILIZANDO TUPLAS (SÃO VARIÁVEIS)
//MANEIRA MAIS RECOMENDADA, POIS FICA MAIS VISUAL O QUE ESTÁ SENDO FEITo
(int Id, string Nome, string Sobrenome, decimal Altura) tuplas = (1, "Ana", "Gomes", 1.80M);
//EXEMPLO 2
ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Ana", "Gomes", 1.80M);
//EXEMPLO 3
var outroExemploTuplaCreate = Tuple.Create(1, "Ana", "Gomes", 1.80M);

Console.WriteLine($"Id: {tuplas.Item1}");
Console.WriteLine($"Nome: {tuplas.Item2}");
Console.WriteLine($"Sobrenome: {tuplas.Item3}");
Console.WriteLine($"Altura: {tuplas.Item4}");
*/













/*
//adionando elemento no dicionario
//é necessario apenas que a key seja com o nome diferente
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("RJ", "Rio de Janeiro");
estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "bahia");

Console.WriteLine(estados["MG"]);

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, value: {item.Value}");
}

Console.WriteLine("----------");

estados.Add("BA2", "bahia");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, value: {item.Value}");
}
Console.WriteLine("----------");

estados.Remove("BA");

//tracando o valor da chave // a chave vai ser sempre a referência
estados["SP"] = "Novo São Paulo";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, value: {item.Value}");
}

string chave = "BA";

Console.WriteLine($"Verificando o elemento: {chave}");

//containsKey verificar se a chave já foi utilizada antes
if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave {chave}");
}
*/









/*
//COLEÇÃO COM STACK - PILHA - LIFO - O PRIMEIRO QUE ENTRA É O ÚLTIMO A SAIR - SAÍDA SEMPRE DO TOPO
//Stack é o nome de pilha

Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(54);
pilha.Push(7);
pilha.Push(5);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}
//o pop remove o elemento do topo
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
//push adiciona uma novo elemento
pilha.Push(23);
foreach (int item in pilha)
{
    Console.WriteLine(item);
}
*/










//COLEÇÃO COM QUEUE - FILA - FIFO - PRIMEIRO QUE ENTRA, PRIMEIRO QUE SAI
//Queue é o nome q se da para fila
//enqueue é nome que se da para adicionar algum elemento na fila
/*Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(64);
fila.Enqueue(3);
fila.Enqueue(14);
fila.Enqueue(8);

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}
*/



















/*
//realiza a litura de um arquivo txt
//try - ele tenta fazer com mais cautela, pois ele sabe que em algum momento pode ocorrer algum erro e criar uma exceção do arquivo
try
{
    string[] linhas = File.ReadAllLines("Arquivo/arquivo.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
    //catch - pegar - ele pega a exceção (erro) e transmite de forma genérica um tratamento na apresentação da leitura
}
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu uma na leitura do arquivo. caminho da pasta não encotrado" + ex.Message);
} 
//erro genérico pode ser qualquer tipo de erro como um arquivo não disponível, caiu a rede da empresa e etc.
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("O código chegou até aqui");
}


*/










/*
//horario atual
DateTime date1 = DateTime.Now;
Console.WriteLine(date1.ToString("dd/MM/yyyy HH:mm"));
*/

















/*forma de formatar o um para moeda é uilizando o :C e converte automáticamente
decimal valorMonetario= 1573.40M;
Console.WriteLine($"{valorMonetario:C}");
//formatando para a moeda de acordo com o  país
//System.Globalization.CultureInfo.CurrentCulture = new CultureInfo("en-Us");"
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-Us")));
*/

















/*// dua intancia da classe pessoa (criar uma variavel e por new))
//usando o construto para otimizar o código
Pessoa p1 = new Pessoa("nana", "silva");
//p1.Nome = "nana";
//p1.Sobrenome = "Silva";

Pessoa p2 = new Pessoa("ana","Lima");
//p2.Nome = "ana";
//p2.Sobrenome = "Lima";

Curso cursoIngles = new Curso();
cursoIngles.Nome = "Inglês";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAlunos(p1);
cursoIngles.AdicionarAlunos(p2);
cursoIngles.ListaAlunos();
*/






















// Pessoa p1 = new Pessoa();

// p1.Nome = "nana";
// p1.Idade = -12;
// p1.Apresentar();


