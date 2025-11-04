using ClassesEObjetos;


// Garrafa g1 = new Garrafa();
// g1.marca = "TupperWare";
// g1.cor = "Azul";
// g1.qtdLitros = 1.5;

// System.Console.WriteLine($"Marca: {g1.marca}");
// System.Console.WriteLine($"Cor: {g1.cor}");
// System.Console.WriteLine($"Quantidade de Litros: {g1.qtdLitros}");
// System.Console.WriteLine();

//--------------- Pessoa ---------------//

// Pessoa Felipe = new Pessoa();

// Felipe.Nome = "Felipe Gonçalves";

// Console.WriteLine($"{Felipe.Nome} tem {Felipe.idade} anos");

// Felipe.Envelhecer(100);

// Console.WriteLine($"{Felipe.Nome} tem {Felipe.idade} anos");

//--------------- Conta Bancaria ---------------//

ContaBancaria cb1 = new ContaBancaria();
System.Console.WriteLine("cadastre o titular da conta");
cb1.titular = Console.ReadLine();

System.Console.WriteLine("Diga o saldo do titular");
cb1.saldo = double.Parse(Console.ReadLine());

System.Console.WriteLine("Agora escolha uma das opções:");
System.Console.WriteLine("  1. Depositar");
System.Console.WriteLine("  2. Sacar");

int opcao = int.Parse(Console.ReadLine());

System.Console.WriteLine();

switch (opcao)
{
    case 1: cb1.Depositar();
        break;

    case 2: cb1.Sacar();
        break;

    default: System.Console.WriteLine("Opção Inválida!");
        break;
}

System.Console.WriteLine($"o saldo atualizado é: {cb1.saldo:F2}");