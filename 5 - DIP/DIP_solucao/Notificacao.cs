
    public class Notificacao
    {
        private IMensagem i_mensagem;
        private string _mensagem;

        // primeira forma
        public Notificacao(string mensagem) {

            _mensagem = mensagem;
            i_mensagem = new Email(); // Aqui está um vinculo pequeno e de fácil manutenção
            // a notificação não sabe enviar um e-mail, apenas usa da interface e determinou 
            // que vai enviar um e-mail, porém pode alterar para qualquer outra forma de 
            // notificação, bastando instanciar outra forma já implantada e que herde de
            // IMensagem            
        }

        public void notificarErro()
        {
            i_mensagem.EnviarMensagem(_mensagem);
        }
    }

