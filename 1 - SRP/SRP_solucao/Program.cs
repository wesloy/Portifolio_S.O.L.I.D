using Funcionarios;

Garcom garcom = new Garcom(); // Esta declaração quebra o SOLID, mas isso é para outro momento
Cozinheiro cozinheiro = new Cozinheiro(); // Esta declaração quebra o SOLID, mas isso é para outro momento
Caixa caixa = new Caixa(); // Esta declaração quebra o SOLID, mas isso é para outro momento

Console.WriteLine("Funcionários trabalhando...");

garcom.AnotarPedido();
cozinheiro.PrepararAlimentos();
cozinheiro.Cozinhar();
cozinheiro.MontarPrato();
garcom.ServirMesa();
caixa.FinalizarConta();
caixa.ReceberPagamento();

// Ao executar o programa tudo ocorre transparente para o usuáiro, porém como se vê acima temos 3 "funcionários", 
// ou seja, 3 classes distintas cuidando apenas de suas funções..
