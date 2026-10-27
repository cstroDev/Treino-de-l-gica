import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe um número:");
let n = Number(ler());

let par = n == 2 || n == 4 || n == 6 || n == 8 || n == 10;

console.log(`Número é par? ${par}`);