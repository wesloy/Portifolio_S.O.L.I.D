// Aqui o LSP é quebrado qdo se fala de bicicleta (comum), mesmo que ela seja um veículo, já que ela não pode ser:
// Ligada, abastecida ou desligada

Veiculo moto = new Moto("Honda shadow 750");

moto.Ligar();
moto.Movimentar();
moto.Abastecer();
moto.Estacionar();
moto.Desligar();

Veiculo carro = new Carro("Vectra GT");

carro.Ligar();
carro.Movimentar();
carro.Abastecer();
carro.Estacionar();
carro.Desligar();

Veiculo bike = new Bicicleta("Absolute 1x12");

bike.Ligar();
bike.Movimentar();
bike.Abastecer();
bike.Estacionar();
bike.Desligar();
