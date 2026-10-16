namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o seu nome:");
        string nome = Console.ReadLine() ?? "";

        Console.WriteLine($"Parabéns {nome} você chegou ao \"final\" \\o/");
    }
}
