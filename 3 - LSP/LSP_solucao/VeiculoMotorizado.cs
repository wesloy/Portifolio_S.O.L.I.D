public abstract class VeiculoMotorizado : Veiculo
{
    private readonly string modelo;

    public VeiculoMotorizado(string modelo) : base(modelo: modelo)
    {
        this.modelo = modelo;
    }

    public void Ligar()
    {
        Console.WriteLine(modelo + " está ligado(a)..");
    }

    public override void Estacionar()
    {
        base.Estacionar();
    }


    public virtual void Abastecer()
    {
        Console.WriteLine(modelo + " está abastecido(a)..");
    }

    public override void Movimentar()
    {
        base.Movimentar();
    }
    public virtual void Desligar()
    {
        Console.WriteLine(modelo + " está desligado(a)..");
    }
}
