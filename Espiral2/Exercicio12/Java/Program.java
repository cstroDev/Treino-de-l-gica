import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe a base e altura de dois retângulos:");
        double baseRetangulo1 = sc.nextDouble();
        double alturaRetangulo1 = sc.nextDouble();
        double baseRetangulo2 = sc.nextDouble();
        double alturaRetangulo2 = sc.nextDouble();

        double areaRetangulo1 = baseRetangulo1 * alturaRetangulo1;
        double areaRetangulo2 = baseRetangulo2 * alturaRetangulo2;
        boolean saoIguais = areaRetangulo1 == areaRetangulo2;

        System.out.printf("O primeiro retângulo possui área %.1f\nO segundo retângulo possui área %.1f\nEles são iguais? %b", areaRetangulo1, areaRetangulo2, saoIguais);
        
        sc.close();
    }

}