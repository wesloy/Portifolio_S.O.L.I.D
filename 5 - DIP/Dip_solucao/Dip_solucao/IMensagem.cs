
    // Implementa o contrato que uma mensagem deve ter
    // Não se preocupa com o meio que vai ser usado para entregar: E-mail, SMS, Push...
    public interface IMensagem
    {
        void EnviarMensagem(string mensagem);
    }

