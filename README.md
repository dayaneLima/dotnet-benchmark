# Benchmark

Este é um projeto de benchmarking simples para comparar o desempenho de diferentes métodos de verificação de strings em uma lista de objetos.

## Descrição

Neste projeto, comparamos duas abordagens para verificar se uma determinada string existe em uma lista de objetos `Pessoa`. 
O objetivo é determinar qual método (`VerificacaoUsandoCount` ou `VerificacaoUsandoAny`) é mais eficiente em termos de desempenho.
Ambos os benchmarks são executados sobre uma lista de 100, 300, 1000, 2000 e 10000 objetos `Pessoa`, preenchida aleatoriamente com nomes e datas de nascimento.

## Criação de um projeto do tipo console

No terminal, navegue até o diretório que deseja criar o projeto e execute o seguinte comando:

```bash
dotnet new console -n nomeProjeto
```

## Instalação da biblioteca de benchmark

```bash
dotnet add package BenchmarkDotNet
```

## Criação da classe para medição

Crie uma classe com o que se deseja medir (Veja o exemplo do arquivo VerificacaoStringExisteListaObjetosBenchmarks.cs)

## Chamada da classe do benchmark para execução

No Program.cs adicione a linha abaixo:

```bash
BenchmarkRunner.Run<VerificacaoStringExisteListaObjetosBenchmarks>();
```

## Como executar

Para executar os benchmarks, você pode usar o Visual Studio ou o .NET CLI. Certifique-se de instalar a biblioteca `BenchmarkDotNet` antes de executar os testes.

### .NET CLI

No terminal, navegue até o diretório do projeto e execute o seguinte comando:

```bash
dotnet build
dotnet run -c Release
```

## Resultados

Os resultados dos benchmarks serão exibidos após a conclusão da execução. Eles incluirão métricas como tempo de execução e alocação de memória para cada método de verificação.
