public class Email
{
    private readonly string _corpoEmail;

    public Email(string corpoEmail)
    {
        _corpoEmail = corpoEmail;
    }

    public void enviarEmail()
    {
        Console.WriteLine(_corpoEmail);
    }

}
