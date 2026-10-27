import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe o valor do lado do octógono:")
let lado = Number(ler());

let perimetro = lado * 8;

console.log(`O perímetro do octógono é ${perimetro}.`);