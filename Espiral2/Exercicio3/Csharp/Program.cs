namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Infome a altura do triângulo:");
        double altura = double.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Informe a base do triângulo:");
        double bas = double.Parse(Console.ReadLine() ?? "");

        double area = altura * bas / 2;

        Console.WriteLine($"A área do triângulo (Altura {altura} x Base {bas}) é {area}");
    }
}
