import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o valor do lado do octógono:");
        int lado = sc.nextInt();

        int perimetro = lado * 8;

        System.out.printf("O perímetro do octógono é %d.", perimetro);

        sc.close();
    }
    
}