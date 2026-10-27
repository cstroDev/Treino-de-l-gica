import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe seu salário base, o bônus mensal em porcentagem e o total de desontos em reais:");
        double salarioBase = sc.nextDouble();
        double bonus = sc.nextDouble();
        double desconto = sc.nextDouble();

        double salarioLiquido = (salarioBase + (bonus / 100 * salarioBase)) - desconto;

        System.out.printf("Seu salário líquido é de R$ %.1f", salarioLiquido);

        sc.close();
    }
    
}