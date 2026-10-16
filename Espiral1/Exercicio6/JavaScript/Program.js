import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe um número:")
let n = Number(ler());

let dobro = n * 2;

console.log(`O dobro de ${n} é ${dobro}!`);