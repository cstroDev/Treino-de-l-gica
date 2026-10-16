import java.util.Scanner;

class Program {

    public static void main(String[] arrgs) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o seu nome:");
        String nome = sc.nextLine();

        System.out.printf("Parabéns %s você chegou ao \"final\" \\o/", nome);

        sc.close();
    }
    
}