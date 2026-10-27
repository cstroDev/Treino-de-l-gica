import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe 3 notas:");
let nota1 = Number(ler());
let nota2 = Number(ler());
let nota3 = Number(ler());

let media = (nota1 + nota2 + nota3) / 3;
let passou = media >= 6;

console.log(`A média do aluno é ${media}
O aluno passou? ${passou}`);