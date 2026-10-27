namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de cada tamanho do açai e o valor do cupom, se houver:");
        int qtdPequeno = int.Parse(Console.ReadLine() ?? "");
        int qtdMedio = int.Parse(Console.ReadLine() ?? "");
        int qtdGrande = int.Parse(Console.ReadLine() ?? "");
        double cupom = double.Parse(Console.ReadLine() ?? "");

        double valorAcai = qtdPequeno * 13.5 + qtdMedio * 15 + qtdGrande * 17.5;

        double total = valorAcai - (cupom / 100 * valorAcai);

        Console.WriteLine($"Total à pagar é R$ {total}");
    }
}
