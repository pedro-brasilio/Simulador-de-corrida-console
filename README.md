# Corrida Simulator

Simulação simples de corrida em C# no console, onde dois competidores avançam aleatoriamente até cruzar a linha de chegada.

## Como funciona

- Dois "corredores" (Pessoa 1 e Pessoa 2) começam na posição 0.
- A cada rodada, cada um avança uma distância aleatória entre 1 e 9 metros.
- O console é limpo e atualizado a cada 500ms, mostrando a distância percorrida por cada corredor.
- O primeiro a atingir (ou ultrapassar) 100 metros vence a corrida.
- Se os dois cruzarem a linha de chegada na mesma rodada, é declarado empate ("foto finish").

## Tecnologias

- C#
- .NET (Console Application)

## Como executar

```bash
dotnet run
```

## Exemplo de saída

```
Corrida iniciada!

Pessoa 1: 45 metros
Pessoa 2: 52 metros
...
Pessoa 2 venceu!
```
