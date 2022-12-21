public class Carro : VeiculoMotorizado
{
    private readonly string modelo;

    public Carro(string modelo) : base(modelo)
    {
        this.modelo = modelo;
    }

    public override void Abastecer()
    {
        Console.WriteLine(modelo + " está abastecido com Etanol..");
    }
}
