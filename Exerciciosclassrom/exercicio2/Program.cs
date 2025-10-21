int gols1;
int gols2;


Console.WriteLine("A quantida de gols do primeiro time");
gols1 = int.Parse(Console.ReadLine());

Console.WriteLine("A quantidade de gols do segundo time");
gols2 = int.Parse(Console.ReadLine());


if (gols1 > gols2)
{
    Console.WriteLine("O time 1 ganhou");
}

else if(gols1 = gols2)
{
    Console.WriteLine("O jogo deu empate");
}

else
{
        Console.WriteLine("O time 2 ganhou");
}