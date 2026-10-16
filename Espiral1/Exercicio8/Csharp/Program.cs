namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número para a base e outro para a altura:");
        int bas = int.Parse(Console.ReadLine() ?? "");
        int altura = int.Parse(Console.ReadLine() ?? "");

        int area = bas * altura;

        Console.WriteLine($"A área do retângulo de base {bas} e altura {altura} é {area}");
    }
}
