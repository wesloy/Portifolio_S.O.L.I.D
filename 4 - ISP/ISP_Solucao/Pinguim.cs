// IAveNadadora é específica e ao mesmo tempo tem os atributos comuns a todoas as Aves
public class Pinguim : IAveNadadora
{
    private readonly string animal = "Pinguim ";

    public void Bicar()
    {
        Console.WriteLine(animal + "pode bicar!");
    }

    public void Nadar()
    {
        Console.WriteLine(animal + "pode nadar!");
    }

}
