import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o valor total da compra e a quantidade de parcelas:");
        int qtdPequeno = sc.nextInt();
        int qtdMedio = sc.nextInt();
        int qtdGrande = sc.nextInt();
        double cupom = sc.nextDouble();

        double valorAcai = qtdPequeno * 13.5 + qtdMedio * 15 + qtdGrande * 17.5;

        double total = valorAcai - (cupom / 100 * valorAcai);

        System.out.printf("Total à pagar é R$ %.2f", total);

        sc.close();
    }
    
}