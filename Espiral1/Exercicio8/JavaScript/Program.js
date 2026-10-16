import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe um número para a base e outro para a altura:");
let base = Number(ler());
let altura = Number(ler());

let area = base * altura;

console.log(`A área do retângulo de base ${base} e altura ${altura} é ${area}`);