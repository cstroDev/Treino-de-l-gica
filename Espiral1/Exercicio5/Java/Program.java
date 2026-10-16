import java.util.Scanner;

class Program {

    public static void main(String[] arrgs) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe seu nome e sua série favorita:");
        String nome = sc.nextLine();
        String serie = sc.nextLine();

        System.out.printf("Ei %s, já tenho os ingressos para ver %s, sei que você adora!", nome, serie);

        sc.close();
    }
    
}