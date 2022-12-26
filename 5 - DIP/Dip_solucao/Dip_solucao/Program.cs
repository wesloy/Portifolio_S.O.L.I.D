
// o meio de envio está determinado "dentro" de notificação
Notificacao notificacao1 = new Notificacao("Log de erro de sistema");
notificacao1.notificarErro();

// o meio de envio deve ser passado para a classe notificação
IMensagem mensagem = new Email();
NotificacaoAlternativa notificacao2 = new NotificacaoAlternativa(mensagem);
notificacao2.notificarErro("Log 2 de erro de sistema");

// Ambas situações o DIP é respeitado, já que o módulo de alto nível, notificação, 
// não depende diretamente do módulo de baixo nível, Email ou qualquer outro (SMS, PUSH), para 
// ser testado, já que está desacoplado.
// Ou seja, não sabe detalhes, que pertence apenas as abstrações saber.