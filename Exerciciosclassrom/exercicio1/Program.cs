double salario;
double gasto;
double resultado;

Console.WriteLine("Digite o seu salario");
salario = int.Parse(Console.ReadLine());

Console.WriteLine("Digite seu gasto");
gasto = int.Parse(Console.ReadLine());

resultado = -1* (salario - gasto);

if (salario >= gasto)
{
    Console.WriteLine("Gastos dentro do orçamento");
}

else
{
    Console.WriteLine($"Orçamento estourado em {resultado}");
}