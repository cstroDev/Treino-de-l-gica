namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número:");
        int n = int.Parse(Console.ReadLine() ?? "");

        double metade = (double) n / 2;

        Console.WriteLine($"A metade de {n} é {metade}");
    }
}
