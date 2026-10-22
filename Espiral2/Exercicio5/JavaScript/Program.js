import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe o valor da compra e o valor do cupom:");
let valorCompra = Number(ler());
let valorCupom = Number(ler());

let valorFinal = valorCompra - (valorCupom / 100 * valorCompra);

console.log(`Compra finalizada! O total é de R$ ${valorFinal}`);