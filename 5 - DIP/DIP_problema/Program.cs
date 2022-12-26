// Neste exemplo a classe Notificação que é de alto nivel depende diretamente de e-mail.
// Quebra o DIP, já que:
// DIP determina que módulos de alto nível não devem depender de módulos de baixo nível. 
// Ambos devem depender de abstrações e abstrações não devem depender de detalhes. 
// Detalhes devem depender de abstrações.

Noticiacao noticiacao = new Noticiacao("Erro no sistema!");
noticiacao.NoticiacarErro();
