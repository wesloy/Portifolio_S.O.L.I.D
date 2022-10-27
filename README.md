# S.O.L.I.D
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/wesloy/Portifolio_S.O.L.I.D/blob/main/license) 

## Sobre o projeto

Este projeto tem como intuito aplicar os princípios SOLID utilizando C#, transformando conceitos em algo mais concretos. Este projeto também será um guia para projetos futuros.

**Observação**: toda palavra seguida de asterisco, possui uma breve descrição na penúltima sessão deste _Redme_, sessão _Glossário_, com o objetivo de elucidar qualquer dúvida sobre a utilização desta palavra no contexto deste "manuscrito".  
Exemplo: Glossário*


## S.O.L.I.D.

Esse termo é um acrônimo:
* **S**ingle Responsibility Principle (Princípio de Responsabilidade Única)
* **O**pen/Closed Principle (Princípio Aberto e Fechado)
* **L**iskov Substitution Principle (Princípio de Substituíção de Liskov)
* **I**nterface Segregation Principle (Princípio de Segregação de Interface)
* **D**ependency Inversion (Princípio da Inversão de Depdência)

SOLID **não é um Desgner Patterns** é na verdade um conjunto de princípios* que tem como objetivo a construção de sistemas mais compreensivos, flexíveis e sustentáveis.


## Single Responsibility Principle ::: Princípio de Responsabilidade Única

> O **SRP** tem como objetivo fazer com que qualquer entidade* tenha apenas uma responsabilidade.

Em outras palavras uma entidade deve ter apenas uma razão de existir. Assim será evidata as "_God Class_", onde uma única classe realiza diversos processos diferentes. Utilizar este princípio será base para todos os demais do SOLID.

#### Vantages: ####

* Reaproveitamento de código
* Fácil refatoração
* Testes unitários com implementação facilitada
* Isolamento de _bugs_ e agilidade de atuação nos mesmos
* Melhor entendimento do código por outros analistas/desenvolvedores
* Motivo único de alteração da entidade

#### Dica: ####

Se houver dificuldade para nomear uma entidade, com um nome **totalmente descritivo** e ao mesmo tempo curto/breve. É um indício de que a entidade tem mais do que uma responsabilidade.


## Glossário ##

* __Entidade__ - classes, módulos, funções, componentes, bibliotecas ou qualquer outra unidade sujeita a alterações no software.
* __Glossário__ - dicionário de palavras de sentido obscuro ou pouco conhecido; elucidário.
* __Princípio__ - modelo, base. Contrário de lei não é obrigatório. Pode-se dizer que trata-se de boas práticas.
