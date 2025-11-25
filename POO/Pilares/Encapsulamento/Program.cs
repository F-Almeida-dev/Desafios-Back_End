using Encapsulamento;

// float dinheiro = -200;

// ContaBancaria contaFelipe = new ContaBancaria();
// ContaBancaria contaLucas = new ContaBancaria(dinheiro);

// contaFelipe.Depositar(dinheiro);
// System.Console.WriteLine($"Novo saldo da Conta R${contaFelipe.GetSaldo()}");

// System.Console.WriteLine($"Novo saldo da Conta R${contaLucas.GetSaldo()}");

// contaFelipe.Saque(100);
// System.Console.WriteLine($"Saldo apos saque do Felipe: R${contaFelipe.GetSaldo()}");


Carro C1 = new Carro();

C1.DefinirMarca("Nissan");
C1.DefinirModelo("GT-R");
C1.DefinirVelocidade(360);

C1.ObterVelocidade();

C1.Acelerar(12);

C1.ObterVelocidade();

C1.Freiar(72);

C1.ObterVelocidade();
