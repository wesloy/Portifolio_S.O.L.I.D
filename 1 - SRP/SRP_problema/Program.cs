using Funcionarios;

Funcionario func = new Funcionario();

Console.WriteLine("Funcionário trabalhando...");
func.AnotarPedido();
func.PrepararAlimentos();
func.Cozinhar();
func.MontarPrato();
func.ServirMesa();
func.FinalizarConta();
func.ReceberPagamento();

// Quanta responsabilidade tem esse funcionário, não concorda?
// Manutenções na classe funcionário poderia parar todo a lanchonete (software)..
