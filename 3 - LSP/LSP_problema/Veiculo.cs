public abstract class Veiculo
{
    private string modelo;

    protected Veiculo(string modelo)
    {
        this.modelo = modelo;
    }

    public void Ligar()
    {
        Console.WriteLine(modelo + " está ligado(a)..");
    }

    public void Movimentar()
    {
        Console.WriteLine(modelo + " está movimentando..");
    }
    public void Abastecer()
    {
        Console.WriteLine(modelo + " está abastecido(a)..");
    }
    public void Estacionar()
    {
        Console.WriteLine(modelo + " está estacionado(a)..");
    }
    public void Desligar()
    {
        Console.WriteLine(modelo + " está desligado(a)..");
    }

}
