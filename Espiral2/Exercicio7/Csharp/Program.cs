namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor total da compra e a quantidade de parcelas:");
        double valorCompra = double.Parse(Console.ReadLine() ?? "");
        double qtdParcelas = double.Parse(Console.ReadLine() ?? "");

        double valorParcela = valorCompra / qtdParcelas;

        Console.WriteLine($"Sua compra de R$ {valorCompra} em {qtdParcelas}x de R$ {valorParcela} foi concluída");
    }
}
