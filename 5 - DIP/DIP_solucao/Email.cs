
    // Implementa o contrato de mensagem para e-mail
    // Porém outros meios como Push, SMS e etc poderiam herdar os mesmos contratos
    public class Email : IMensagem
    {
   
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }

