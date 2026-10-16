import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe um número:");
let n = Number(ler());

let area = n * n;

console.log(`A área do quadrado de lado ${n} é ${area}.`);