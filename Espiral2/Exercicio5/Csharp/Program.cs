namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor da compra e o valor do cupom:");
        double valorCompra = double.Parse(Console.ReadLine() ?? "");
        double valorCupom = double.Parse(Console.ReadLine() ?? "");

        double valorFinal = valorCompra - (valorCupom / 100 * valorCompra);

        Console.WriteLine($"Compra finalizada! O total é de R$ {valorFinal}");
    }
}
