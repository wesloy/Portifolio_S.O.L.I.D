public class Bicicleta : Veiculo
{
    private readonly string modelo;

    public Bicicleta(string modelo) : base(modelo)
    {
        this.modelo = modelo;
    }

    public override void Movimentar()
    {
        Console.WriteLine(modelo + " está pedalando..");
    }

    public override void Estacionar()
    {
        Console.WriteLine(modelo + " está no tripé..");
    }
}
