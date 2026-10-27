import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe a quantidade de cada tamanho do açai e o valor do cupom, se houver:");
let qtdPequeno = Number(ler());
let qtdMedio = Number(ler());
let qtdGrande = Number(ler());
let cupom = Number(ler());

let valorAcai = qtdPequeno * 13.5 + qtdMedio * 15 + qtdGrande * 17.5;

let total = valorAcai - (cupom / 100 * valorAcai);

console.log(`Total à pagar é R$ ${total}`);