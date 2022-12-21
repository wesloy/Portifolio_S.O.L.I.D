using Funcionarios;

Garcom garcom = new Garcom();
Cozinheiro cozinheiro = new Cozinheiro();
Caixa caixa = new Caixa();

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
