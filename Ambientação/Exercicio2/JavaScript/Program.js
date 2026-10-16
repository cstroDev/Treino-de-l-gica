import prompt from 'prompt-sync';
let ler = prompt();

console.log("Qual é o seu nome?")
let nome = ler();

console.log("Seja bem-vindo " + nome);