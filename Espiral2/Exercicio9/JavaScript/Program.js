import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe seu salário base, o bônus mensal em porcentagem e o total de desontos em reais:");
let salarioBase = Number(ler());
let bonus = Number(ler());
let desconto = Number(ler());

let salarioLiquido = (salarioBase + (bonus / 100 * salarioBase)) - desconto;

console.log(`Seu salário líquido é de R$ ${salarioLiquido}`);