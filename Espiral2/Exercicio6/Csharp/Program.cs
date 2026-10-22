namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade em Kg:");
        double kg = double.Parse(Console.ReadLine() ?? "");

        double gramas = kg * 1000;

        Console.WriteLine($"{gramas}g");
    }
}
