public class Noticiacao
{

    private string _mensagem;
    private Email _email;

    public Noticiacao(string mensagem)
    {
        _mensagem = mensagem;
        _email = new Email(_mensagem); // auto acoplamento 
    }

    public void NoticiacarErro()
    {
        _email.enviarEmail();
    }



}
