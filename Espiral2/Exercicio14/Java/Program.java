import java.util.Scanner;

class Program {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Qual é o personagem de Friends que trabalha com TI?");
        String respostaUsuario = sc.nextLine();

        String respostaCorreta = "Chandler";
        boolean comparacaoResposta = respostaUsuario.equals(respostaCorreta);
        
        System.out.printf("Resposta correta....: %s", comparacaoResposta);
        
        sc.close();
    }

}