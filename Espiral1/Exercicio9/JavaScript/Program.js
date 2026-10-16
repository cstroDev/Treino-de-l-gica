import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe o nome de três amigos:");
let a1 = ler();
let a2 = ler();
let a3 = ler();

console.log(`Seus melhores amigos são:
1. ${a1}
2. ${a2}
3. ${a3}`);