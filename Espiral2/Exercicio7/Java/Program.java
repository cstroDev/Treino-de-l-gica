import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o valor total da compra e a quantidade de parcelas:");
        double valorCompra = sc.nextDouble();
        int qtdParcela = sc.nextInt();

        double valorParcela = valorCompra / (double) qtdParcela;

        System.out.printf("Sua compra de R$ %.2f em %dx de R$ %.2f foi concluída", valorCompra, qtdParcela, valorParcela);

        sc.close();
    }
    
}