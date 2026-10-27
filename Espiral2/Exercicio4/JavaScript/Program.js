import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe quatro notas:");
let nota1 = Number(ler());
let nota2 = Number(ler());
let nota3 = Number(ler());
let nota4 = Number(ler());

let media = (nota1 + nota2 + nota3 + nota4) / 4;

console.log(`A média é ${media}`);