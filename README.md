# S.O.L.I.D
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/wesloy/Portifolio_S.O.L.I.D/blob/main/license) 

## Sobre o projeto

Este projeto tem como intuito aplicar os princípios SOLID utilizando C#, transformando conceitos em algo mais concretos. Este projeto também será um guia para projetos futuros, independente da linguagem a ser utilizada.

**Observação**: toda palavra seguida de asterisco, possui uma breve descrição na penúltima sessão deste _Redme_, sessão _Glossário_, com o objetivo de elucidar qualquer dúvida sobre a utilização desta palavra no contexto deste artigo. Exemplo: Glossário*


## S.O.L.I.D.

Esse termo é um acrônimo:
* **S**ingle Responsibility Principle (Princípio de Responsabilidade Única)
* **O**pen/Closed Principle (Princípio Aberto e Fechado)
* **L**iskov Substitution Principle (Princípio de Substituíção de Liskov)
* **I**nterface Segregation Principle (Princípio de Segregação de Interface*)
* **D**ependency Inversion Principle (Princípio da Inversão de Depdência)

SOLID **não é um Desgner Patterns** é na verdade um conjunto de princípios* que tem como objetivo a construção de sistemas mais compreensivos, flexíveis e sustentáveis.  


O que será facilmente identificado ao se ler este artigo é que os princípios SOLID são inter-relacionados e diretamente dependentes um do outro, em alguns casos são sutís diferenças que devem ser observadas para conseguir visualizar o princípio que você está buscanco analisar. Em sintese, uma excelente aplicação do SOLID em seu código fará com que 2, 3 ou até mais princípios estejam presentes em apenas uma entidade*. 


## Single Responsibility Principle ::: Princípio de Responsabilidade Única

> O **SRP** tem como objetivo fazer com que qualquer entidade tenha apenas uma responsabilidade.

Em outras palavras uma entidade deve ter apenas uma razão de existir. Assim será evidata as "_God Class_", onde uma única classe realiza diversos processos diferentes. Utilizar este princípio será base para todos os demais do SOLID.

#### Exemplo: ####

#### Vantages: ####

* Motivo único de alteração da entidade
* Reaproveitamento de código
* Fácil refatoração
* Testes unitários com implementação* facilitada
* Isolamento de _bugs_ e agilidade de atuação nos mesmos
* Melhor entendimento do código por outros analistas/desenvolvedores

#### Dica: ####

Se houver dificuldade para nomear uma entidade, com um nome **totalmente descritivo** e ao mesmo tempo curto/breve. É um indício de que a entidade tem mais do que uma responsabilidade.


## Open/Closed Principle ::: Princípio Aberto e Fechado

> O ***OCP*** dita que uma entidade está aberta para extensão e fechada para modificação.

De modo simples, a entidade está ***fechada*** para ser alterada. Muitas vezes, alguns programadores se vêem motivados a **modificar** uma entidade e colocar um "_if_" para resolver uma nova situação nova que surja. Justificando que é apenas uma condição, mas esquecendo que qualquer que seja a outra entidade que possa herdar desta também será afetada e ainda mais, não levando em conta que em futuro breve ou não outras condicionais poderão surgir, fazendo com que o código fique poluído e difícil de ser entendido e dada a devida manutenção.

E ela está **aberta** para ser extendida, quando outras entidades podem usá-la por herança e adicionar novas funcionalidades. 

Mudar é sempre um risco, extender é garantir que o que estava implementado continue a funcionar e a nova regra de negócio será apenas para uma extensão de algo que já está funcional.

#### Exemplo: ####

#### Vantages: ####

* Redução de complexidade ciclomáticas* e elimando cláusulas condicionais
* Reaproveitamento de código, por extender uma entidade filha ao invés de modificar a entidade pai
* Fácil refatoração
* Testes unitários com implementação facilitada
* Isolamento de _bugs_ e agilidade de atuação nos mesmos
* Melhor entendimento do código por outros analistas/desenvolvedores

#### Dica: ####

Se o código possui _"Ifs"_ com a intenção de validar todas as variáveis externas que surgiram é um alerta de que a OCP deve ser olhado com carinho.


## Liskov Substitution Principle ::: Princípio de Substituíção de Liskov ##
> **LSP** prega que uma entidade base deve poder ser substituída por uma entidade derivada, sem prejuízo para o software e que as entidades derivadas nunca devem infligir as definições/comportamentos da entidade base. 

O LSP, tem foco nas abstrações e para que seu princípio seja obedecido, refatora-se a abstração base para um nível que realmente possa atender de forma genérica, sem obrigar que as entidades derivadas façam testes lógicos ("_Ifs_") para evitar exceções.

#### Exemplo: ####

#### Vantages: ####

* Provoca o nível correto e necessário de abstração
* Reaproveitamento de código, por extender uma entidade filha ao invés de modificar a entidade pai (Implanta OCP)
* Fácil refatoração
* Testes unitários com implementação facilitada
* Isolamento de _bugs_ e agilidade de atuação nos mesmos
* Melhor entendimento do código por outros analistas/desenvolvedores

#### Dica: ####

Se o código possui _"Ifs"_ com a intenção de validar todas as variáveis externas que surgiram é um alerta de que a LSP deve ser olhado com carinho. Quanto a essa dica a diferença existente entre o LSP e OCP é que o LSP foca exclusivamente na abstração.

## Interface Segregation Principle ::: Princípio de Segregação de Interface ##
> **ISP** tem como princípio que os clientes* que implementam uma interface **não devem** ser obrigados a implementar uma ação/método que não utiliza.

O ISP é a aplicação dos princípios SRP, OCP e LSP, direcionandos para interfaces.

#### Exemplo: ####

#### Vantages: ####

* Provoca o nível correto e necessário de abstração na interface
* Reaproveitamento de código, por se criar interfaces mais específicas do que genéricas, lembrando que uma classe que implementa pode, se necessário, implementar várias interfaces.
* Fácil refatoração
* Testes unitários com implementação facilitada
* Isolamento de _bugs_ e agilidade de atuação nos mesmos
* Melhor entendimento do código por outros analistas/desenvolvedores

#### Dica: ####

Se um cliente precisar "passar por alto" algum método da interface e/ou a atualização da interface* provoque este mesmo efeito em outras classes que já estão implementadas é sinal de que o ISP está sendo infligido.  
**Observação:** alterar uma interface, para incluir um novo método é extremamente perigoso, visto que pode quebrar o software de diversas formas diferentes. Isto apenas se deve ser feito no caso específico de que todas as implementações necessitem deste novo método.

## Dependency Inversion Principle ::: Princípio da Inversão de Depdência ##
> **DIP** determina que módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações e abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.  


O DIP em poucas palavras diz "Dependa de uma abstração e não de uma implementação".  
Olhando para as vantagens descritas abaixo, nota-se que o DIP é, por assim dizer, o mais importante de todos os princípios. Já que sua aplicação depende que todos os outros princípios sejam bem trabalhados.

#### Exemplo: ####

#### Vantages: ####

* Ao declarar abstrações e criar implementações específicas a partir delas, satisfazemos o SRP;
* Trabalhar com variáveis do tipo de Interfaces e instanciar tipos concretos em tempo de execução nos remete ao propósito do OCP;
* Abstrações favorecem a modelagem correta de classes e subclasses, cumprindo o LSP;
* A inversão de dependência promove a segregação de Interfaces, representada pelo ISP, já que novas estruturas de alto nível são elaboradas.

#### Dica: ####

Se um método recebe como parâmetro um objeto concreto ou dentro de uma classe é necessário instanciar (inicializar um objeto) é um forte indicador de que o DIP está quebrado em sua aplicação.  


## Links Úteis / Referências ##

Filipe Deschamps - SOLID - https://www.youtube.com/watch?v=6SfrO3D4dHM  
Código Fonte TV - SOLID - https://www.youtube.com/watch?v=mkx0CdWiPRA  
Igor Luna - SOLID C# - https://github.com/igorluna/solid-workshop  
André Celestino - OCP - https://www.andrecelestino.com/solid-open-closed-principle-ocp/  
André Celestino - LSP - https://www.andrecelestino.com/solid-liskov-substitution-principle-lsp/  
André Celestino - DIP - https://www.andrecelestino.com/solid-dependency-inversion-principle-dip/  



## Glossário ##

* __Cliente__ - nesse artigo refere-se a entidades que implementam uma abstração ou interface.
* __Complexidade ciclomática__ - é uma métrica do campo da engenharia de software, desenvolvida por Thomas J. McCabe em 1976, e serve para mensurar a complexidade de uma determinada entidade, a partir da contagem do número de caminhos independentes que ele pode executar até o seu fim.
* __Entidade__ - classes, módulos, funções, componentes, bibliotecas ou qualquer outra unidade sujeita a alterações no software.
* __Glossário__ - dicionário de palavras de sentido obscuro ou pouco conhecido; elucidário.  
* __Implementação__ - códificação que transcreve em linguagem de programação a regra de negócio ou cálculo que se espera obter.
* __Interface__ - determina um contrato ou os métodos que se deve implementar quando a mesma (interface) é herdada, ou seja, é uma forma de _template_ ou identidiade.
* __Princípio__ - modelo, base. Contrário de lei não é obrigatório. Pode-se dizer que trata-se de boas práticas.


