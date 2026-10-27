namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu salário base, o bônus mensal em porcentagem e o total de desontos em reais:");
        double salarioBase = double.Parse(Console.ReadLine() ?? "");
        double bonus = double.Parse(Console.ReadLine() ?? "");
        double desconto = double.Parse(Console.ReadLine() ?? "");

        double salarioLiquido = (salarioBase + (bonus / 100 * salarioBase)) - desconto;

        Console.WriteLine($"Seu salário líquido é de R$ {salarioLiquido}");
    }
}