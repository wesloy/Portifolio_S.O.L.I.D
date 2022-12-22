
// Herença multipla para cobrir as funções comuns e específicas
public class Gaviao : IAve, IAveVoadora
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
