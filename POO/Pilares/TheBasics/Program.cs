using TheBasics;
Console.Clear();

// List<Pessoa> peoples = new List<Pessoa>();

// Endereco enderecoEdu = new Endereco();
// enderecoEdu.Logradouro = "Rua Niterói";


// Endereco enderecoPhil = new Endereco();
// enderecoPhil.Logradouro = "Rua Dali";


// Endereco enderecoHen = new Endereco();
// enderecoHen.Logradouro = "Rua Praca";


// Endereco enderecoElo = new Endereco();
// enderecoElo.Logradouro = "Rua Dela";


// Pessoa eduardo = new Pessoa(enderecoEdu);
// Pessoa philip = new Pessoa(enderecoPhil);
// Pessoa henrique = new Pessoa(enderecoHen);
// Pessoa eloysa = new Pessoa(enderecoElo);

// eduardo.Nome = "Eduardo";
// eduardo.Idade = 43;

// philip.Nome = "Felipe";
// philip.Idade = 17;

// henrique.Nome = "Henrique";
// henrique.Idade = 17;

// eloysa.Nome = "Eloysa";
// eloysa.Idade = 17;

// peoples.Add(eduardo);
// peoples.Add(philip);
// peoples.Add(henrique);
// peoples.Add(eloysa);

// //For each

// foreach (var Pessoa in peoples)
// {
//     Console.WriteLine($"--------------------");
//     Console.WriteLine($"Nome: {Pessoa.Nome}");
//     Console.WriteLine($"Idade: {Pessoa.Idade}");
//     Console.WriteLine($"--------------------");
// }



// string[] nomes = { "Eduardo", "Lucas" };

// Console.WriteLine($"Quantidades de pessoas da lista: {peoples.Count}");
// Console.WriteLine($"Qantidade de pessoas do array: {nomes.Length}");

// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Spínola Teixeira";
// endEnzo.Numero = 3960;
// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Nome = "Pedro Enzo";
// pedroEnzo.Curso = "Desenvolvimento de Sistema";
// pedroEnzo.RA = "1234-xpto";
// pedroEnzo.NotaFinal = 9.75f;

// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua lá de casa";
// endProfAlex.Numero = 987;

// Professor profAlexia = new Professor(endProfAlex);
// profAlexia.Nome = "Aléxia Vitória";

// System.Console.WriteLine($"Aluno {pedroEnzo.Nome} estuda na turma {pedroEnzo.Curso} da profa. {profAlexia}");

Carro fusca = new Carro();
fusca.Marca = "Wolksvagem";
fusca.Modelo = "Fusca";

Moto dominar400 = new Moto();
dominar400.Marca = "Bajaj";
dominar400.Modelo = "Dominar 400";

fusca.Ligar();