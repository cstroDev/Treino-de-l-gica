namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a sua temperatura:");
        double temperatura = double.Parse(Console.ReadLine() ?? "");

        bool estaComFebre = temperatura > 37.3;

        Console.WriteLine($"Você está com febre? {estaComFebre}");
    }
}