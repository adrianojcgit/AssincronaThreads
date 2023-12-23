using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        ExecutarComThreads();
        sw.Stop();
        Console.WriteLine($"A contagem demorou {sw.ElapsedMilliseconds} segundos");
    }

    static void ExecutarSequencial()
    {
        RealizarOperacao(1, "Adriano", "Cordeiro");
        RealizarOperacao(2, "Sandra", "Pinheiro");
        RealizarOperacao(3, "Fabio", "Alencar");
    }

    static void ExecutarComThreads()
    {
        var t1 = new Thread(() =>
        {
            RealizarOperacao(1, "Adriano", "Cordeiro");
        });
        var t2 = new Thread(() =>
        {
            RealizarOperacao(2, "Sandra", "Pinheiro");
        });
        var t3 = new Thread(() =>
        {
            RealizarOperacao(3, "Fabio", "Alencar");
        });

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
    }
    static void RealizarOperacao(int op, string nome, string segundoNome)
    {
        Console.WriteLine($"Iniciando operação {op}...");
        for (int i = 0; i < 1000000000; i++)
        {
            var p = new Pessoa(nome, segundoNome, 30);
        }
        Console.WriteLine($"Operação {op} finalizada!");
    }
}