using System.Reflection;

int n = 0, i = 1, q = 1;

Console.WriteLine("Quantos numeros voce deseja digitar");
n = int.Parse(Console.ReadLine());

while(q <= n)
{
    Console.WriteLine("Digite um numero");
    i = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        Console.WriteLine($"O numero digitado é par: {i}");
    }
    n++;
}