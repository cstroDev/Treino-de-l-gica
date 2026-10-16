import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o nome de três amigos:");
        String a1 = sc.nextLine();
        String a2 = sc.nextLine();
        String a3 = sc.nextLine();

        System.out.printf("""
Seus melhores amigos são:
1. %s
2. %s
3. %s""", a1, a2, a3);

        sc.close();
    }
    
}