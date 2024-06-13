using System.Text;
using BenchmarkDotNet.Attributes;

namespace BenchmarkSimples;

[MemoryDiagnoser]
public class VerificacaoStringExisteListaObjetosBenchmarks
{
    private readonly List<Pessoa> pessoas = [];
    private static readonly Random random = new Random();

    [Params(100, 300, 1000, 2000, 10000)]
    public int totalItensGerados;

    [GlobalSetup]
    public void GlobalSetup()
    {
        for (int i = 0; i < totalItensGerados; i++)
            pessoas.Add(new Pessoa(GerarStringAleatoria(50), GerarDataNascimento(1900,2000)));
    }

    [Benchmark]
    public bool VerificacaoUsandoCount() => pessoas.Count(pessoa => pessoa.Nome.Equals(pessoas[totalItensGerados/2].Nome)) > 0;

    [Benchmark]
    public bool VerificacaoUsandoAny() => pessoas.Any(pessoa => pessoa.Nome.Equals(pessoas[totalItensGerados/2].Nome));

    private static string GerarStringAleatoria(int tamanho)
    {
        const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ";
        var sb = new StringBuilder();

        for (int i = 0; i < tamanho; i++)
        {
            int indice = random.Next(caracteresPermitidos.Length);
            sb.Append(caracteresPermitidos[indice]);
        }

        return sb.ToString();
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