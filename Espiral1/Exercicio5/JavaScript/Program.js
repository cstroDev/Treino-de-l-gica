import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe seu nome e sua série favorita:")
let nome = ler();
let serie = ler();

console.log(`Ei ${nome}, já tenho os ingressos para ver ${serie}, sei que você adora!`);