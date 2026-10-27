import prompt from 'prompt-sync';
let ler = prompt();

console.log("Qual é o personagem de Friends que trabalha com TI?");
let respostaUsuario = ler();

let respostaCorreta = "Chandler";
let comparacaoResposta = respostaUsuario == respostaCorreta;

console.log(`Resposta correta....: ${comparacaoResposta}`);