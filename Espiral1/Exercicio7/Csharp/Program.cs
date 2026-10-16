namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número:");
        int n = int.Parse(Console.ReadLine() ?? "");

        int area = n * n;

        Console.WriteLine($"A área do quadrado de lado {n} é {area}.");
    }
}
