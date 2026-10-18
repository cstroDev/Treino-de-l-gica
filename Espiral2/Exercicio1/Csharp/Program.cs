namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor do lado do octógono:");
        int lado = int.Parse(Console.ReadLine() ?? "");

        int perimetro = lado * 8;

        Console.WriteLine($"O perímetro do octógono é {perimetro}.");
    }
}
