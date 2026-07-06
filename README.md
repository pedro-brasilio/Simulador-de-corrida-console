# Simulador de Corrida

Projeto simples desenvolvido em C# para praticar conceitos de Programação Orientada a Objetos (POO), incluindo classes, propriedades, encapsulamento, construtores, validações e métodos.

## Sobre o projeto

O programa simula o controle de velocidade de carros. Cada carro possui um modelo e começa com velocidade igual a `0 km/h`.

O sistema permite acelerar e brecar os veículos, validando os valores informados e impedindo que a velocidade fique negativa.

## Funcionalidades

- Criar carros com um modelo definido;
- Iniciar cada carro com velocidade igual a `0 km/h`;
- Acelerar o carro com valores maiores que zero;
- Brecar o carro com valores maiores que zero;
- Impedir que a velocidade fique negativa;
- Validar modelos vazios ou inválidos;
- Exibir no terminal a velocidade atual após cada ação.

## Conceitos aplicados

- Programação Orientada a Objetos (POO);
- Classes e objetos;
- Encapsulamento;
- Propriedades com leitura e escrita controladas;
- Construtores;
- Validação de dados;
- Tratamento de exceções;
- Métodos para representar comportamentos do objeto.

## Exemplo de execução

```text
O carro Sedan acelerou e agora está a 30 km/h.
O carro Hatch acelerou e agora está a 40 km/h.
O carro Sedan brecou e agora está a 20 km/h.
O carro Hatch brecou e agora está a 0 km/h.
```

## Tecnologias utilizadas

- C#
- .NET 10
- Console Application

## Estrutura do projeto

```text
simulador-de-corrida/
├── SimuladorDeCorrida.slnx          # Solution
├── README.md
├── .gitignore
└── src/
    └── SimuladorDeCorrida/          # Projeto console
        ├── SimuladorDeCorrida.csproj
        ├── Program.cs               # Ponto de entrada da aplicação
        └── Models/
            └── Carro.cs             # Entidade Carro (modelo + velocidade)
```

## Como executar

Requisitos: [.NET SDK 10](https://dotnet.microsoft.com/download) instalado.

1. Clone o repositório:
   ```bash
   git clone https://github.com/pedro-brasilio/simulador-de-corrida.git
   cd simulador-de-corrida
   ```
2. Execute o projeto:
   ```bash
   dotnet run --project src/SimuladorDeCorrida
   ```

Também é possível abrir o arquivo `SimuladorDeCorrida.slnx` diretamente no Visual Studio ou no VS Code e executar pela IDE.

## Autor

Pedro Luciano Brasilio dos Santos  
Estudante de Análise e Desenvolvimento de Sistemas.
