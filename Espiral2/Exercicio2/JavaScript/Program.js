import prompt from 'prompt-sync';
let ler = prompt();

console.log("Infome um número:")
let n = Number(ler());

let metade = n / 2;

console.log(`A metade de ${n} é ${metade}`);