using BenchmarkDotNet.Attributes;

namespace BenchmarkSimples;

[MemoryDiagnoser]
public class VerificacaoStringExisteListaObjetosBenchmarks
{
    private readonly List<Pessoa> pessoas = [];
    private static readonly Random random = new Random();

    [GlobalSetup]
    public void GlobalSetup()
    {
        for (int i = 0; i < 1000; i++)
            pessoas.Add(new Pessoa(GerarNomeCompleto(), GerarDataNascimento(1900,2000)));
    }

    [Benchmark]
    public bool VerificacaoUsandoCount() => pessoas.Count(pessoa => pessoa.Nome.Equals(pessoas[500].Nome)) > 0;

    [Benchmark]
    public bool VerificacaoUsandoAny() => pessoas.Any(pessoa => pessoa.Nome.Equals(pessoas[500].Nome));

    private static string GerarNomeCompleto()
    {
        var nomes = new List<string> { "João", "Maria", "José", "Ana", "Pedro", "Mariana", "Carlos", "Isabela", "Antônio", "Laura" };
        var sobrenomes = new List<string> { "Silva", "Santos", "Oliveira", "Souza", "Pereira", "Costa", "Sousa", "Ferreira", "Almeida", "Araújo" };

        return  $"{nomes[random.Next(nomes.Count)]} {sobrenomes[random.Next(sobrenomes.Count)]}";
    }

    private static DateTime GerarDataNascimento(int anoInicial, int anoFinal)
    {
        int ano = random.Next(anoInicial, anoFinal + 1);
        int mes = random.Next(1, 13);
        int dia = random.Next(1, DateTime.DaysInMonth(ano, mes) + 1);

        return new DateTime(ano, mes, dia);
    }
}

public record Pessoa(string Nome, DateTime DataNascimento);