import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe a altura do triângulo:");
        int altura = sc.nextInt();

        System.out.println("Informe a base do triângulo:");
        int base = sc.nextInt();

        double area = (double) altura * (double) base / 2;

        System.out.printf("A área do triângulo (Altura %d x Base %d) é %.1f", altura, base, area);

        sc.close();
    }
    
}