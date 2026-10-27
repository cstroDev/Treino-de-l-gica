import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe 3 notas:");
        double nota1 = sc.nextDouble();
        double nota2 = sc.nextDouble();
        double nota3 = sc.nextDouble();

        double media = (nota1 + nota2 + nota3) / 3;
        boolean passou = media >= 6;

        System.out.printf("A média do aluno é %.1f\nO aluno passou? %b", media, passou);

        sc.close();
    }
    
}