public class Pinguim : IAve
{
    private readonly string animal = "Pinguim ";

    public void Bicar()
    {
        Console.WriteLine(animal + "pode bicar!");
    }

    // Violaão do ISP, obrigando a implantar algo que não pode ser feito por essa classe
    public void Voar()
    {
        Console.WriteLine(animal + "NÃO pode voar!");
    }

}
