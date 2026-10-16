import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe um número:");
        int n = sc.nextInt();

        int dobro = n * 2;

        System.out.printf("O dobro de %d é %d!", n, dobro);

        sc.close();
    }
    
}