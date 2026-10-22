import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe a quantidade em Kg:");
        double kg = sc.nextDouble();
        
        double gramas = kg * 1000;

        System.out.printf("%.1fg", gramas);

        sc.close();
    }
    
}