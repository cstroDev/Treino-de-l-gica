import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe um número:");
        int n = sc.nextInt();

        boolean par = n == 2 || n == 4 || n == 6 || n == 8 || n == 10;
        
        System.out.printf("Número é par? %b", par);
        
        sc.close();
    }

}