namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe 3 notas:");
        double nota1 = double.Parse(Console.ReadLine() ?? "");
        double nota2 = double.Parse(Console.ReadLine() ?? "");
        double nota3 = double.Parse(Console.ReadLine() ?? "");

        double media = (nota1 + nota2 + nota3) / 3;
        bool passou = media >= 6;

        Console.WriteLine($@"A média do aluno é {media}
O aluno passou? {passou}");
    }
}