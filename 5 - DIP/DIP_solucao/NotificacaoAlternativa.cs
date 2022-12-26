
    public class NotificacaoAlternativa
    {
        private IMensagem i_mensagem;

        // Segunda forma
        // Repassada a responsabilidade de criar o meio de envio
        // para quem declarar a classe Notificação, assim sendo quem instanciar 
        // notificação determina o canal.. SMS, EMAIL, PUSH.. desde que essas formas
        // herdem de IMensagem
        public NotificacaoAlternativa(IMensagem mensagem)         {
            i_mensagem = mensagem;
         
        }

        public void notificarErro(string mensagem)
        {
            i_mensagem.EnviarMensagem(mensagem);
        }
    }

