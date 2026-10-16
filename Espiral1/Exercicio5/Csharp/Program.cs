namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome e sua série favorita:");
        string nome = Console.ReadLine() ?? "";
        string serie = Console.ReadLine() ?? "";

        Console.WriteLine($"Ei {nome}, já tenho os ingressos para ver {serie}, sei que você adora!");
    }
}
