import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Qual é o seu nome?");
        String nome = sc.nextLine();

        System.out.println("Seja bem-vindo " + nome);

        sc.close();
    }
    
}