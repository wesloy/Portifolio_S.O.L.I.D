// Herença multipla para cobrir as funções comuns e específicas
public class Pinguim : IAve, IAveNadadora
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
