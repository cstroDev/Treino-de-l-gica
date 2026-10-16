import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe um número para a base e outro para a altura:");
        int base = sc.nextInt();
        int altura = sc.nextInt();

        int area = base * altura;

        System.out.printf("A área do retângulo de base %d e altura %d é %d", base, altura, area);

        sc.close();
    }
    
}