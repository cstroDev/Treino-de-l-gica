namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o nome de três amigos:");
        string a1 = Console.ReadLine() ?? "";
        string a2 = Console.ReadLine() ?? "";
        string a3 = Console.ReadLine() ?? "";

        Console.WriteLine($@"Seus melhores amigos são:
1. {a1}
2. {a2}
3. {a3}");
    }
}
