using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        RealizarOperacao(1, "Adriano", "Cordeiro");
        sw.Stop();
        Console.WriteLine($"A contagem demorou {sw.ElapsedMilliseconds} segundos");
    }

    private static void RealizarOperacao(int op, string nome, string segundoNome)
    {
        Console.WriteLine($"Iniciando operação {op}...");
        for (int i = 0; i < 1000000000; i++)
        {
            var p = new Pessoa(nome, segundoNome, 30);
        }
        Console.WriteLine($"Operação {op} finalizada!");
    }
}