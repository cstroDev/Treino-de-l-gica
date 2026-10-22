import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o valor da compra e o valor do cupom:");
        double valorCompra = sc.nextDouble();
        double valorCupom = sc.nextDouble();

        double valorFinal = valorCompra - (valorCupom / 100 * valorCompra);

        System.out.printf("Compra finalizada! O total é de R$ %f", valorFinal);

        sc.close();
    }
    
}