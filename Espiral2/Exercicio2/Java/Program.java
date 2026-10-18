import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe um número:");
        int n = sc.nextInt();

        double metade = (double) n / 2;

        System.out.printf("A metade de %d é %.1f", n, metade);

        sc.close();
    }
    
}