import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe a quantidade em Kg:");
let kg = Number(ler());

let gramas = kg * 1000;

console.log(`${gramas}g`);