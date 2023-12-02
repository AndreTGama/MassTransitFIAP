# Projeto Monolito com MassTransit - C#

Este projeto monolítico, desenvolvido em C#, utiliza a biblioteca MassTransit para comunicação assíncrona entre três aplicações distintas: Core, Produtor e Consumidor.

## Estrutura do Projeto

### Core
A aplicação Core é a base do projeto, contendo apenas duas classes principais: `Pedidos` e `Usuario`. Essas classes representam entidades do sistema e fornecem dados para o processo de comunicação entre as aplicações.

### Produtor
O Produtor desempenha o papel de produtor no MassTransit. Sua função é enviar eventos para o barramento MassTransit, notificando sobre a criação de novos pedidos ou usuários.

### Consumidor
O Consumidor é responsável por receber e processar os eventos do barramento MassTransit. Neste projeto, ele exibe as informações no terminal usando `Console.WriteLine`.

## Como Funciona

1. Ao executar a aplicação Core, as classes `Pedidos` e `Usuario` são inicializadas.

2. O Produtor, ao identificar uma nova criação de pedido ou usuário, envia um evento para o barramento MassTransit.

3. O Consumidor, aguardando no barramento, recebe os eventos e processa-os, exibindo as informações no terminal.

## Executando o Projeto

1. Execute a aplicação Core para criar instâncias de pedidos e usuários.

2. Execute o Produtor para enviar os eventos para o barramento.

3. Execute o Consumidor para visualizar as informações no terminal.

## Observações

Este projeto foi desenvolvido com base nas aulas da FIAP e segue uma abordagem didática para facilitar o entendimento do uso do MassTransit em um cenário monolítico em C#.
