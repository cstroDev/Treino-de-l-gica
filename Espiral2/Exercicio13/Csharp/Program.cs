namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número:");
        int n = int.Parse(Console.ReadLine() ?? "");
        
        bool par = n == 2 || n == 4 || n == 6 || n == 8 || n == 10;

        Console.WriteLine($"Número é par? {par}");
    }
}