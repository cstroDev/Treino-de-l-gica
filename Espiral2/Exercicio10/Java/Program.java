import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe a sua temperatura:");
        double temperatura = sc.nextDouble();
    
        boolean estaComFebre = temperatura > 37.3;

        System.out.printf("Você está com febre? %b", estaComFebre);

        sc.close();
    }
    
}