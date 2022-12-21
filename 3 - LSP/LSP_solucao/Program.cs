// Neste exemplo podemos ver o nível certo de desacoplamento e herança
// Agora uma bicicleta (comum) não pode ser ligada, abastecida ou desligada
// e como o LSP traz o principio de substituição da classe filha pela pai, sem quebrar
// isso pode ocorrer, entre veículos motorizados, bem como veículos

VeiculoMotorizado moto = new Moto("Honda shadow 750");

moto.Ligar();
moto.Movimentar();
moto.Abastecer();
moto.Estacionar();
moto.Desligar();

VeiculoMotorizado carro = new Carro("Vectra GT");

carro.Ligar();
carro.Movimentar();
carro.Abastecer();
carro.Estacionar();
carro.Desligar();

Veiculo bike = new Bicicleta("Absolute 1x12");

bike.Movimentar();
bike.Estacionar();

