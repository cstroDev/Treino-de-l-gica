import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe a altura do triângulo:");
let altura = Number(ler());

console.log("Informe a base do triângulo:");
let base = Number(ler());

let area = base * altura / 2

console.log(`A área do triângulo (Altura ${altura} x Base ${base}) é ${area}`);