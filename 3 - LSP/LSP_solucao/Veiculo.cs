public abstract class Veiculo
{
    private readonly string modelo;

    public Veiculo(string modelo)
    {
        this.modelo = modelo;
    }

    public virtual void Movimentar()
    {
        Console.WriteLine(modelo + " está movimentando..");
    }

    public virtual void Estacionar()
    {
        Console.WriteLine(modelo + " está estacionado(a)..");
    }

}
