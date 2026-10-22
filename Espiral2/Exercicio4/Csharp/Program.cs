namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Infome quatro notas:");
        double nota1 = double.Parse(Console.ReadLine() ?? "");
        double nota2 = double.Parse(Console.ReadLine() ?? "");
        double nota3 = double.Parse(Console.ReadLine() ?? "");
        double nota4 = double.Parse(Console.ReadLine() ?? "");

        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        Console.WriteLine($"A média é {media}");
    }
}
