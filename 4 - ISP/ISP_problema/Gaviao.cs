
public class Gaviao : IAve
{
    private readonly string animal = "Gavião ";

    public void Bicar()
    {
        Console.WriteLine(animal + "pode bicar!");
    }

    public void Voar()
    {
        Console.WriteLine(animal + "pode voar!");
    }

}
