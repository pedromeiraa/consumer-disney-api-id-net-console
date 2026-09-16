# Console-DisneyAPI

Aplicação em C# para consultar um personagem da Disney por meio da API pública do Disney API.

## Descrição

Este projeto é um console app que faz uma requisição HTTP para a API do Disney e exibe o nome e a imagem do personagem solicitado.

Neste caso, a aplicação consulta o personagem com ID 423 e imprime no terminal:

- Nome
- URL da imagem

## Requisitos

- .NET SDK 10.0 ou superior
- Internet para acessar a API

## Como executar

1. Abra o terminal na raiz do projeto.
2. Execute o comando:

```bash
dotnet run
```

3. A aplicação irá consultar a API e exibir os dados do personagem.

## Estrutura do projeto

```text
DisneyAPI/
├── DisneyAPI.csproj
├── Program.cs
├── README.md
├── bin/
└── obj/
```

## Endpoint utilizado

A aplicação usa a seguinte URL:

```text
https://api.disneyapi.dev/character/423
```

## Exemplo de saída

```text
Nome:
Mickey Mouse
Imagem:
https://static.wikia.nocookie.net/disney/images/...
```

## Observação

A API retorna um JSON com dados do personagem. A aplicação usa `System.Text.Json` para desserializar o retorno em classes C# e acessar as propriedades `name` e `imageUrl`.
