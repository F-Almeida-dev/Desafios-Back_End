// See https://aka.ms/new-console-template for more information
using ClassesEstatias;

Console.WriteLine("Bem vindo ao programa");
System.Console.WriteLine();

// System.Console.WriteLine($"Digite um número");
// float a = float.Parse(Console.ReadLine());

// System.Console.WriteLine($"Digite outro número");
// float b = float.Parse(Console.ReadLine());

// //uso da classe estática de forma auxiliar
// float r = CalculosMatematicos.Somar(a, b);
// System.Console.WriteLine($"Soma: {r}");

// r = CalculosMatematicos.Subtrair(a, b);
// System.Console.WriteLine($"Subtração: {r}");

// r = CalculosMatematicos.Multiplicar(a, b);
// System.Console.WriteLine($"Multiplicação: {r}");

// r = CalculosMatematicos.Dividir(a, b);
// System.Console.WriteLine($"Divisão: {r}");

// System.Console.WriteLine($"Valor de PI é: {Math.PI}");
// System.Console.WriteLine($"Potência de 3 elevado a 2 é {Math.Pow(3, 2)}");

//Solicitar ao usuário 2 números reais e informar qual é o maior e qual é o menor dos números 
//Para isso você deve utilizar a classe Math, Utilitário do C#

System.Console.Write($"Digite o primeiro numero: ");
float a = float.Parse(Console.ReadLine());

System.Console.Write($"Digite o segndo numero: ");
float b = float.Parse(Console.ReadLine());

// Se fosse preciso validação
if(a == b)
{
    System.Console.WriteLine($"Os dois Números são iguais");
}
else
{
    System.Console.WriteLine($"O maior numero é: {Math.Max(a,b)}");
    System.Console.WriteLine($"O menor numero é: {Math.Min(a,b)}");
}

System.Console.WriteLine($"O maior numero é: {Math.Max(a,b)}");
System.Console.WriteLine($"O menor numero é: {Math.Min(a,b)}");