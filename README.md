# Screen Sound 2.0

Aplicação de console desenvolvida em **C#** para cadastro e gerenciamento de bandas, álbuns e músicas.

O projeto foi desenvolvido como prática de **Programação Orientada a Objetos (POO)** e utiliza diferentes conceitos da linguagem C#, como classes, interfaces, encapsulamento, coleções e herança de responsabilidades entre as classes.

## Funcionalidades

A aplicação possui um menu interativo com as seguintes opções:

- 🎸 Registrar uma banda
- 💿 Registrar um álbum para uma banda
- 📋 Mostrar todas as bandas cadastradas
- ⭐ Avaliar uma banda
- ⭐ Avaliar um álbum
- 🔎 Exibir os detalhes de uma banda
- 🚪 Encerrar o programa

## Tecnologias utilizadas

- **C#**
- **.NET 10**
- **Visual Studio**
- Aplicação de console

## Estrutura do projeto

```text
Screen-Sound--2.0/
├── ScreenSound.sln
├── ScreenSound/
│   ├── Menus/
│   │   ├── Menu.cs
│   │   ├── MenuAvaliarAlbum.cs
│   │   ├── MenuAvaliarBanda.cs
│   │   ├── MenuExibirDetalhes.cs
│   │   ├── MenuMostrarBandas.cs
│   │   ├── MenuRegistrarAlbum.cs
│   │   ├── MenuRegistrarBanda.cs
│   │   └── MenuSair.cs
│   ├── Modelos/
│   │   ├── Album.cs
│   │   ├── Avaliacao.cs
│   │   ├── Banda.cs
│   │   ├── IAvaliavel.cs
│   │   └── Musica.cs
│   ├── Program.cs
│   └── ScreenSound.csproj
└── README.md
```

## Conceitos de C# praticados

Durante o desenvolvimento foram utilizados conceitos importantes de orientação a objetos, incluindo:

- Classes e objetos
- Encapsulamento
- Propriedades
- Interfaces
- Coleções como `List<T>` e `Dictionary<TKey, TValue>`
- `IEnumerable<T>`
- Métodos e construtores
- Organização do código em diferentes classes
- Separação entre modelos e menus

## Como executar

### Pré-requisitos

É necessário ter o **.NET 10 SDK** instalado.

### Executando pelo terminal

Clone o repositório:

```bash
git clone https://github.com/KauaOBarboza/Screen-Sound--2.0.git
```

Entre na pasta do projeto:

```bash
cd Screen-Sound--2.0
```

Execute a aplicação:

```bash
dotnet run --project ScreenSound
```

## Exemplo do menu

Ao iniciar o programa, será apresentado um menu semelhante a:

```text
Digite 1 para registrar uma banda
Digite 2 para registrar o álbum de uma banda
Digite 3 para mostrar todas as bandas
Digite 4 para avaliar uma banda
Digite 5 para avaliar um álbum
Digite 6 para exibir os detalhes de uma banda
Digite -1 para sair
```

## Objetivo

Este projeto faz parte dos estudos de **C# e Programação Orientada a Objetos**, com foco na construção de uma aplicação de console organizada e na prática dos principais recursos da linguagem.

## Autor

**Kauã Oliveira Barboza**

Projeto desenvolvido para fins de estudo.
