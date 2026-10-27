import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe a sua temperatura:");
let temperatura = Number(ler());

let estaComFebre = temperatura > 37.3;

console.log(`Você está com febre? ${estaComFebre}`);