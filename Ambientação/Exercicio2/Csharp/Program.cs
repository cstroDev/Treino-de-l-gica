namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual é o seu nome?");
        string? nome = Console.ReadLine();
        
        Console.WriteLine("Seja bem-vindo " + nome);
    }
}
