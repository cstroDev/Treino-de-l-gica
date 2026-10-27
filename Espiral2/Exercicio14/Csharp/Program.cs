namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual é o personagem de Friends que trabalha com TI?");
        string respostaUsuario = Console.ReadLine() ?? "";

        string respostaCorreta = "Chandler";
        bool comparacaoResposta = respostaUsuario == respostaCorreta;

        Console.WriteLine($"Resposta correta....: {comparacaoResposta}");
    }
}