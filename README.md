# Injeção de Dependência - Projetos de Exemplo

Este repositório contém implementações simples que exemplificam a utilização da injeção de dependência em C#. Cada projeto é descrito brevemente abaixo:

## Demo

Este projeto utiliza a injeção de dependência nativa do .NET para aplicar o padrão repository. Ele demonstra como organizar e isolar o acesso a dados por meio de interfaces e implementações específicas.

## Demo 1

Neste exemplo, são criadas operações em diferentes escopos temporais de serviços no container de injeção de dependência. Isso ilustra como o tempo de vida das instâncias pode impactar o comportamento da aplicação.

## Demo 2

Este projeto aplica a injeção de dependência e o padrão repository com tipos genéricos. A interface a ser utilizada só é especificada em tempo de execução, proporcionando maior flexibilidade na escolha das implementações.

## Demo 3

Demonstração do uso de injeção de dependência via propriedade. Isso mostra como as dependências podem ser injetadas diretamente nas propriedades das classes.

## Demo 4

Neste exemplo, as instâncias da interface são obtidas diretamente do provedor de serviços (ServiceProvider). Isso destaca uma maneira direta de acessar dependências sem a necessidade de injeção explícita.

## Demo 5

Utiliza delegates `Func` e `Enum` para trabalhar com uma interface implementada por mais de uma classe. Isso permite uma abordagem dinâmica na seleção da implementação com base em condições específicas.

## Demo 6

Este projeto utiliza o Autofac para injeção de dependência e implementa o contexto e as interfaces no container. Mostra como configurar o Autofac para gerenciar a resolução de dependências de forma eficiente.

## Autores

Estes projetos de exemplo foram criados para fins educacionais. [Marcelo] é responsável pela criação e manutenção destes projetos.

## Licença

Estes projetos não possuem uma licença específica e são fornecidos apenas para fins de aprendizado e demonstração.

