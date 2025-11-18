//Exercicio 1
// Crie uma interface chamada IForma com o método CalcularArea.
// Crie duas classes que implementem essa interface: Retangulo e Circulo
// No program, peça o valor necessário e exiba a área calculada para cada forma
// No Retângulo utilizar o calculo = Largura * Altura ;
// No circulo utilizar o calculo = PI * Raio * Raio;
//Extra: Pesquisar sobre a classe mth do C# e utilizar a constante PI - Math.PI

using System.Security.AccessControl;
using Exercicio01;

Circulo C1 = new Circulo();
Retangulo R1 = new Retangulo();



Console.WriteLine("----------------------------------------------");
Console.WriteLine("Qual o raio do circulo");
C1.Raio = double.Parse(Console.ReadLine());
C1.CalcularArea();
Console.WriteLine("----------------------------------------------");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("----------------------------------------------");
Console.WriteLine("Qual a altura do retângulo");
R1.Altura = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Qual a largura do retângulo");
R1.Largura = double.Parse(Console.ReadLine());
R1.CalcularArea();
Console.WriteLine("----------------------------------------------");
Console.WriteLine();
Console.WriteLine();