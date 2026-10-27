namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a base e altura de dois retângulos:");
        double baseRetangulo1 = double.Parse(Console.ReadLine() ?? "");
        double alturaRetangulo1 = double.Parse(Console.ReadLine() ?? "");
        double baseRetangulo2 = double.Parse(Console.ReadLine() ?? "");
        double alturaRetangulo2 = double.Parse(Console.ReadLine() ?? "");

        double areaRetangulo1 = baseRetangulo1 * alturaRetangulo1;
        double areaRetangulo2 = baseRetangulo2 * alturaRetangulo2;
        bool saoIguais = areaRetangulo1 == areaRetangulo2;

        Console.WriteLine($@"O primeiro retângulo possui área {areaRetangulo1}.
O segundo retângulo possui área {areaRetangulo2}.
Eles são iguais? {saoIguais}");
    }
}