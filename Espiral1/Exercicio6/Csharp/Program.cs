namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número:");
        int n = int.Parse(Console.ReadLine() ?? "");

        int dobro = n * 2;

        Console.WriteLine($"O dobro de {n} é {dobro}!");
    }
}
