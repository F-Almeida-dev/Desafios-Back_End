using Exercicio2;
// Console.Clear();
// Relatorio r1 = new Relatorio();
// r1.Imprimir();
// Contrato c1 = new Contrato();
// c1.Imprimir();
// Fatura f1 = new Fatura();
// f1.Imprimir();


// List<Fatura> listadeFaturas = new List<Fatura>();

// Fatura fatZe = new Fatura();
// fatZe.Dono = "Zé da esquina";
// Fatura fatMaria = new Fatura();
// fatMaria.Dono = "Maria Eduarda";
// Fatura fatEdu = new Fatura();
// fatEdu.Dono = "Eduardo Mendes";
// Fatura fatJoao = new Fatura();
// fatJoao.Dono = "Joao vitor";
// Fatura fatHenrique = new Fatura();
// fatHenrique.Dono = "Henrique";
// Fatura fatMarcos = new Fatura();
// fatMarcos.Dono = "Marcos Vinicius";
// Fatura fatHugo = new Fatura();
// fatHugo.Dono = "Hugo";
// Fatura fatDavi = new Fatura();
// fatDavi.Dono = "Davi Muniz";
// Fatura fatLucas = new Fatura();
// fatLucas.Dono = "Lucas Marinheiro";

// listadeFaturas.Add(fatDavi);
// listadeFaturas.Add(fatEdu);
// listadeFaturas.Add(fatHugo);
// listadeFaturas.Add(fatMaria);
// listadeFaturas.Add(fatMarcos);
// listadeFaturas.Add(fatHenrique);
// listadeFaturas.Add(fatJoao);
// listadeFaturas.Add(fatLucas);

// foreach (var item in listadeFaturas)
// {
//     item.Imprimir();
// }

// List<Relatorio> listadeRelatorio = new List<Relatorio>();

// Relatorio fatFe = new Relatorio();
// fatFe.Nome = "Felipe";
// Relatorio fatLuca = new Relatorio();
// fatLuca.Nome = "Luca Marinheiro";

// listadeRelatorio.Add(fatFe);
// listadeRelatorio.Add(fatLuca);

// foreach (var item in listadeRelatorio)
// {
//     item.Imprimir();
// }

// List<Contrato> listadeContrato = new List<Contrato>();

// Contrato fatThiago = new Contrato();
// fatThiago.Nome = "Thiaguinho";
// Contrato fatCrevelaro = new Contrato();
// fatCrevelaro.Nome = "Crevelaro Fontes";

// listadeContrato.Add(fatThiago);
// listadeContrato.Add(fatCrevelaro);

// foreach (var item in listadeContrato)
// {
//     item.Imprimir();
// }

using Exercicio2;

// Cria uma lista de objetos Fatura
List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;
do
{
System.Console.WriteLine("Menu de opção");
System.Console.WriteLine($@"
0) Sair
1) Cadastrar Fatura
2) Cadastrar Relatorio
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatório
6) Listar Contratos

Escolher a opção:
");
opcao = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite <Enter> para continuar ...");
Console.ReadLine();

    switch (opcao)
    {
        case 1:
            System.Console.WriteLine("Quem você deseja cadastrar n afatura?");
            return;
    }
} while (opcao != 0);


       //Funções auxiliares
void CadastrarFatura()
{
    Console.WriteLine($"Digite o nome do devedor");
    string dev = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite o nome do credor");
    string cred = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite o valor (R$)");
    double valor = double.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine($"Dias atrasados");
    int diasAtraso = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
}


void CadastrarContrato()
{
    Console.WriteLine($"Digite o nome do contratante");
    string contratante = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite o nome do PrestadorServiso");
    string PrestadorServiso = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite as  clausulas");
    string TextoClausulas = Console.ReadLine();
    Console.WriteLine();

    Contrato C = new Contrato(contratante, PrestadorServiso, TextoClausulas);
}


void CadastrarRelatorio()
{
    Console.WriteLine($"Digite o nome do autor do relatorio");
    string Nome = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine($"Digite o texto relatorio");
    string TextoRelatorio = Console.ReadLine();
    Console.WriteLine();

    Relatorio R = new Relatorio(Nome, TextoRelatorio);
}
