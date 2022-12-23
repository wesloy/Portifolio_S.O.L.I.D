// IAveVoadora é específica e ao mesmo tempo tem os atributos comuns a todoas as Aves
public class Gaviao : IAveVoadora
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
