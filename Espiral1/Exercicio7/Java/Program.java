import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe um número:");
        int n = sc.nextInt();

        int area = n * n;

        System.out.printf("A área do quadrado de lado %d é %d.", n, area);

        sc.close();
    }
    
}