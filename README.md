# BenchmarkSimples

Este é um projeto de benchmarking simples para comparar o desempenho de diferentes métodos de verificação de strings em uma lista de objetos.

## Descrição

Neste projeto, comparamos duas abordagens para verificar se uma determinada string existe em uma lista de objetos `Pessoa`. 
O objetivo é determinar qual método (`VerificacaoUsandoCount` ou `VerificacaoUsandoAny`) é mais eficiente em termos de desempenho.

## Configuração

O projeto utiliza o framework de benchmarking `BenchmarkDotNet` para executar os testes de desempenho. Ele inclui duas classes de benchmark:

- `VerificacaoUsandoCount`: Utiliza o método `Count` para verificar se a string existe na lista de pessoas.
- `VerificacaoUsandoAny`: Utiliza o método `Any` para verificar se a string existe na lista de pessoas.

Ambos os benchmarks são executados sobre uma lista de 1000 objetos `Pessoa`, preenchida aleatoriamente com nomes e datas de nascimento.

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
